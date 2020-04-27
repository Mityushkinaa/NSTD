using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSTD
{
    public partial class NSTD : Form

    {
        readonly string sConnStr = new NpgsqlConnectionStringBuilder
        {
            Host = Database.Default.Host,
            Port = Database.Default.Port,
            Database = "arm",
            Username = "postgres",
            Password = "1234",
            MaxAutoPrepare = 10,
            AutoPrepareMinUsages = 2
        }.ConnectionString;
        string field_type;
        List<Field> fields = new List<Field>();
        List<Field> seletedFields = new List<Field>();
        List<Field> unvisitedTab = new List<Field>();
        Dictionary<string, int> cont = new Dictionary<string, int>();

        Dictionary<string, int> tmper = new Dictionary<string, int>();
        int countZap = 0;

        public void SearchRelations(NpgsqlConnection sConn, string Table1, string Table2)
        {
            string Relations, Via;
            NpgsqlCommand Command = new NpgsqlCommand()
            {
                Connection = sConn,
                CommandText = @"select relations, via from public.rel_table
                                where (table1='" + Table1 + "' or table2='" + Table1 +
                                "') and (table1='" + Table2 + "' or table2='" + Table2 + @"')
                                order by relations Desc"
            };
            var reader = Command.ExecuteReader();
            reader.Read();
            try
            {
                Relations = (string)reader["relations"];
                cont[Relations] = 1;
                reader.Close();
            }
            catch
            {
                Via = (string)reader["via"];
                reader.Close();
                tmper[Via] = 1;
                SearchRelations(sConn, Table1, Via);
                SearchRelations(sConn, Table2, Via);
            }
        }

        NpgsqlCommand globalCommand = new NpgsqlCommand
        {
            //Connection = sConn,
            CommandText = @"select field_name, table_name, field_type, transl_fn, category_name from public.fields order by category_name"
        };


        public string genSql()
        {
            cont.Clear();
            string sql = "";
            string select = "SELECT distinct ";
            string from = " FROM ";
            string where = " AND (";
            string order = " ORDER BY ";
            string tab = "";
            int OrdCount = 0;
            Dictionary<string, int> vrem = new Dictionary<string, int>();
            foreach (ListViewItem selectedItem in lbSelectedFields.Items)
            {

                var field = ((Field)selectedItem.Tag);
                select += field.tableName + "." + field.fieldName  + ", ";
                if (field.order != "" && field.order != null)
                {
                    order += field.tableName + "." + field.fieldName + " " + field.order + ", ";
                    OrdCount++;
                }
                
                vrem[field.tableName] = 1;
            }
            if (OrdCount == 0)
                order = " ";

            

            

            for (int i = 0; i < unvisitedTab.Count; i++)
            {
                vrem[unvisitedTab[i].tableName] = 1;
            }

            foreach (var pair in vrem)
            {
                from += pair.Key + ", ";
            }
            from = from.Remove(from.Length - 2);
            if (vrem.Count > 1)
            {
                for (int i = 0; i < vrem.Count; i++)
                {
                    for (int j = i + 1; j < vrem.Count; j++)
                    {
                        using (var sConn = new NpgsqlConnection(sConnStr))
                        {
                            sConn.Open();
                            SearchRelations(sConn, vrem.ElementAt(i).Key, vrem.ElementAt(j).Key);
                        }
                    }

                }
                foreach (var pair in tmper)
                {
                    int param = pair.Value;
                    if (!vrem.TryGetValue(pair.Key, out param))
                    {
                        from += ", " + pair.Key;
                    }
                }
                tmper.Clear();
                from += "\nWHERE ";
                foreach (var item in cont)
                {
                    from += item.Key + " AND ";
                }
                from = from.Remove(from.Length - 5);

            }

            string whereCom = " AND (";
            if (!from.Contains("WHERE"))
            {
                where = " WHERE (";
                whereCom = " WHERE (";
            }
            if (lvConditions.Items.Count == 0)
            {
                where = " ";
                whereCom = " ";
            }
            else
            {
                foreach (ListViewItem selectedItem in lvConditions.Items)
                {

                    where += ((Tuple<string, string, string, string>)selectedItem.Tag).Item1 + " ";
                    whereCom += ((Tuple<string, string, string, string>)selectedItem.Tag).Item2 + " ";

                }
                where += ") ";
                whereCom += ") ";
            }
            string sqlComm = select.Trim(',', ' ') + from + whereCom + order.Trim(',', ' ');
            globalCommand.CommandText = @sqlComm;
           // MessageBox.Show(globalCommand.CommandText);
            sql = select.Trim(',', ' ') + from + where + order.Trim(',', ' ');
            return sql;
        }

        public List<string> getValues(string table, string field)
        {
            List<string> values = new List<string>();
            using (var sConn = new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = @"select distinct " + field + " from " + table
                };

                var reader = sCommand.ExecuteReader();
              
                while (reader.Read())
                {
                    values.Add(reader[0].ToString());
                }
            }          
            return values;
        }

        public NSTD()
        {
            InitializeComponent();
            initFields();
        }

        public void initFields() {
            using (var sConn =new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = @"select field_name, table_name, field_type, transl_fn, category_name from public.fields order by category_name"
                };

                var reader = sCommand.ExecuteReader();

                while (reader.Read())
                {
                    fields.Add(new Field (reader["field_name"].ToString(), reader["table_name"].ToString(),
                                            reader["field_type"].ToString(), reader["transl_fn"].ToString(), reader["category_name"].ToString()));
                }
            }
            string category = "";
            foreach (var field in fields)
            {
                if(category != field.categoryName)
                {
                    lbAllFields.Items.Add("-----" + field.categoryName.ToUpper() + "------").Tag = null;
                    category = field.categoryName;
                   
                }
                

                lbAllFields.Items.Add(field.translFN).Tag = field;               
                cbNameField.Items.Add(field.translFN + "(" + field.categoryName + ")");
            }

        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbSelectedFields.SelectedItems)
            {

                var field = ((Field)selectedItem.Tag);
                field.order = null;
                selectedItem.Text = field.translFN;



            }
        }

        private void radioButtonDesc_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbSelectedFields.SelectedItems)
            {

                var field = ((Field)selectedItem.Tag);
                field.order = "DESC";
                selectedItem.Text = field.translFN + "(убыващющий порядок)";



            }
        }

        private void radioButtonAsc_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbSelectedFields.SelectedItems)
            {

                var field = ((Field)selectedItem.Tag);
                field.order = "ASC";
                selectedItem.Text = field.translFN + "(возрастающий порядок)";
               


            }
        }

        private void btAllFieldLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbSelectedFields.Items)
            {
                seletedFields.Remove((Field)selectedItem.Tag);

                lbSelectedFields.Items.Remove(selectedItem);



            }
            btExecQuery.Enabled = false;
            btWatchQuery.Enabled = false;
        }

        private void btAllFieldRight_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbAllFields.Items)
            {
                if (selectedItem.Tag != null)
                {
                    if (!seletedFields.Contains((Field)selectedItem.Tag))
                    {
                        //   lbAllFields.Items.Remove(selectedItem);
                        seletedFields.Add((Field)selectedItem.Tag);
                        // int ind = seletedFields.IndexOf((Field)selectedItem.Tag);
                        lbSelectedFields.Items.Add(((Field)selectedItem.Tag).translFN).Tag = (Field)selectedItem.Tag;
                       

                    }


                }

            }
            btExecQuery.Enabled = true;
            btWatchQuery.Enabled = true;
        }

        private void btFieldRight_Click(object sender, EventArgs e)
        {
          //  var i = lbAllFields.SelectedIndices;
            foreach (ListViewItem selectedItem in lbAllFields.SelectedItems)
            {
                if (selectedItem.Tag != null)
                {
                    if (!seletedFields.Contains((Field)selectedItem.Tag))
                    {
                        var field = (Field)selectedItem.Tag;
                        if (radioButtonAsc.Checked == true)
                        {
                            field.order = "ASC";
                            lbSelectedFields.Items.Add(field.translFN + "(возрастающий порядок)").Tag = field;
                        }
                        else
                        {
                            if (radioButtonDesc.Checked == true)
                            {
                                field.order = "DESC";
                                lbSelectedFields.Items.Add(field.translFN + "(убывающий порядок)").Tag = field;
                            }
                            else {
                                lbSelectedFields.Items.Add(field.translFN).Tag = field;
                            }
                        }
                        seletedFields.Add(field);
                        // int ind = seletedFields.IndexOf((Field)selectedItem.Tag);
                        
                        //   lbAllFields.Items.Remove(selectedItem);
                       
                    }
                   
                    
                }
               
            }
            btExecQuery.Enabled = true;
            btWatchQuery.Enabled = true;
        }

        private void btFieldLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbSelectedFields.SelectedItems)
            {
                seletedFields.Remove((Field)selectedItem.Tag);

                lbSelectedFields.Items.Remove(selectedItem);
              
                

            }
            if (lbSelectedFields.Items.Count == 0)
            {
                btExecQuery.Enabled = false;
                btWatchQuery.Enabled = false;
            }
        }

        private void lbSelectedFields_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lbSelectedFields.SelectedItems)
            {

                string order = ((Field)selectedItem.Tag).order;
                if (order == "ASC")
                    radioButtonAsc.Checked = true;
                else
                {
                    if (order == "DESC")
                        radioButtonDesc.Checked = true;
                    else
                        radioButtonNo.Checked = true;
                }


            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string dist = "";
            if (cbNameField.Text != "" && cbFilter.Text != "")
            {
                var ind = cbNameField.SelectedIndex;               
                string expression = "";
                string exp1 = "";
                
                if (cbExpression.Visible)
                {
                    if (cbExpression.Text.Length > 100)
                    {
                        MessageBox.Show("Значение выражения слишком длинное");
                        return;
                    }
                    if (fields[ind].fieldType == "character varying")
                    {
                        expression = "'" + cbExpression.Text + "'";
                        exp1 = cbExpression.Text;
                    }
                    else
                    {
                        expression = cbExpression.Text.Replace(',', '.');
                        exp1 = cbExpression.Text;
                    }
                    cbExpression.Text = "";
                }
                if (dpExpression.Visible)
                {

                    expression = "'" + dpExpression.Value.ToShortDateString() + "'";
                    dpExpression.Value = DateTime.Now;
                   
                }
                unvisitedTab.Add(fields[ind]);
                string zapr = "@exp" + Convert.ToString(countZap);
                dist = (cbConnective.Text + " " + fields[ind].tableName + "." + fields[ind].fieldName + " " + cbFilter.Text + " " + expression);
                string comTx = (cbConnective.Text + " " + fields[ind].tableName + "." + fields[ind].fieldName + " " + cbFilter.Text + " " + zapr);

                var tuple = Tuple.Create(dist, comTx, zapr, exp1);
                ListViewItem lvi = new ListViewItem(new[]
                    {
                        cbNameField.Text, cbFilter.Text, expression, cbConnective.Text
                    })
                { Tag = tuple};
                countZap++;
                bool flag = true;
                if (field_type == "other")
                {
                    int x;
                    double y;
                    if (!Int32.TryParse((exp1), out x))
                    {
                        if (!Double.TryParse((exp1), out y))
                        {
                            MessageBox.Show("Введите числовое значение");
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    lvConditions.Items.Add(lvi);
                    //cbNameField.SelectedIndex = 0;
                    //cbFilter.SelectedIndex = 0;
                    cbConnective.Enabled = true;
                    cbConnective.Items.Clear();
                    cbConnective.Items.AddRange(new[] { "AND", "OR" });
                    cbConnective.SelectedIndex = 0;
                }
               // MessageBox.Show(dist);
            }
            else
                MessageBox.Show("Некорректное условие!");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int ind = -1;
            foreach (ListViewItem selectedItem in lvConditions.SelectedItems)
            {
                ind = selectedItem.Index;
                lvConditions.Items.Remove(selectedItem);
                
                unvisitedTab.RemoveAt(ind);

            }
            if(lvConditions.Items.Count == 0)
            {
                cbConnective.Items.Clear();
                cbConnective.Items.AddRange(new[] { "" });
            }
            if (ind == 0 && lvConditions.Items.Count != 0)
            {
                string tmp1 = ((Tuple<string, string, string, string>)lvConditions.Items[0].Tag).Item1;
                string tmp2 = ((Tuple<string, string, string, string>)lvConditions.Items[0].Tag).Item2;
                string tmp3 = ((Tuple<string, string, string, string>)lvConditions.Items[0].Tag).Item3;
                string tmp4 = ((Tuple<string, string, string, string>)lvConditions.Items[0].Tag).Item4;
                lvConditions.Items[0].Tag =  Tuple.Create(tmp1.TrimStart('A', 'N', 'D', 'O', 'R'), tmp2.TrimStart('A', 'N', 'D', 'O', 'R'),
                    tmp3, tmp4);
                lvConditions.Items[0].SubItems[3].Text = "";

            }

        }



        private void cbNameField_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbConnective.Items.Clear();
            var ind = cbNameField.SelectedIndex;
            cbFilter.Items.Clear();
            cbExpression.Items.Clear();
            field_type = "";
            if (lvConditions.Items.Count == 0)
            {
                cbConnective.Enabled = false;
            }
            else
            {
                cbConnective.Enabled = true;
                cbConnective.Items.AddRange(new[] { "AND", "OR" });
                cbConnective.SelectedIndex = 0;
            }
            if (fields[ind].fieldType == "character varying")
            {
                cbExpression.Visible = true;
                dpExpression.Visible = false;              
                cbExpression.DropDownStyle = ComboBoxStyle.DropDown;
                cbFilter.Items.AddRange(new[] { "=", "<>", "LIKE"}); //возможен LIKE
                foreach (string value in getValues(fields[ind].tableName, fields[ind].fieldName) )
                {
                    cbExpression.Items.Add(value);
                }
            }
            else
            {
                if(fields[ind].fieldType == "date")
                {
                    cbExpression.Visible = false;
                    dpExpression.Visible = true;                          
                    cbFilter.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=", });
                }
                else
                {
                    if(fields[ind].fieldType == "bool")
                    {
                        cbExpression.Visible = true;
                        dpExpression.Visible = false;
                       
                        cbExpression.DropDownStyle = ComboBoxStyle.DropDownList;

                        cbFilter.Items.AddRange(new[] { "=", "<>" });
                        cbExpression.Items.AddRange(new[] { "0", "1" });
                    }
                    else
                    {
                        cbExpression.Visible = true;
                        dpExpression.Visible = false;
                        cbExpression.DropDownStyle = ComboBoxStyle.DropDown;
                        cbFilter.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=", });
                        foreach (string value in getValues(fields[ind].tableName, fields[ind].fieldName))
                        {
                            cbExpression.Items.Add(value);
                        }
                        field_type = "other";
                    }
                }
            }
            
        }

        private void tpConditions_Click(object sender, EventArgs e)
        {

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btWatchQuery_Click(object sender, EventArgs e)
        {
            MessageBox.Show(genSql());
        }

        private void btExecQuery_Click(object sender, EventArgs e)
        {
            using (var sConn = new NpgsqlConnection(sConnStr))
            {
                sConn.Open();
                DataTable table = new DataTable();
                string sql = genSql();
                globalCommand.Connection = sConn;
                globalCommand.Parameters.Clear();
                foreach(ListViewItem selectedItem in lvConditions.Items)
                {
                    string val = ((Tuple<string, string, string, string>)selectedItem.Tag).Item3;
                    string zn = ((Tuple<string, string, string, string>)selectedItem.Tag).Item4;
                    int x;
                    double y;
                    if (Double.TryParse(zn, out y))
                    {
                        if(Int32.TryParse(zn, out x))
                            globalCommand.Parameters.AddWithValue(val, x);
                        else
                            globalCommand.Parameters.AddWithValue(val, y);
                    }
                    else
                        globalCommand.Parameters.AddWithValue(val, zn);
                }
             //   MessageBox.Show(Convert.ToString( globalCommand.Parameters[0].Value));
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(globalCommand);
                dataAdapter.Fill(table);
                dgvResult.DataSource = table;
            }
        }

        private void lbAllFields_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
