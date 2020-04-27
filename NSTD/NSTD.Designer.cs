
namespace NSTD
{
    partial class NSTD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFields = new System.Windows.Forms.TabPage();
            this.lbSelectedFields = new System.Windows.Forms.ListView();
            this.lbAllFields = new System.Windows.Forms.ListView();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.btAllFieldLeft = new System.Windows.Forms.Button();
            this.btAllFieldRight = new System.Windows.Forms.Button();
            this.btFieldRight = new System.Windows.Forms.Button();
            this.btFieldLeft = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConditions = new System.Windows.Forms.TabPage();
            this.dpExpression = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cbConnective = new System.Windows.Forms.ComboBox();
            this.cbExpression = new System.Windows.Forms.ComboBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbNameField = new System.Windows.Forms.ComboBox();
            this.lvConditions = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConnective = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpResult = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btWatchQuery = new System.Windows.Forms.Button();
            this.btExecQuery = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpFields.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.tpConditions.SuspendLayout();
            this.tpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFields);
            this.tabControl1.Controls.Add(this.tpConditions);
            this.tabControl1.Controls.Add(this.tpResult);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 340);
            this.tabControl1.TabIndex = 2;
            // 
            // tpFields
            // 
            this.tpFields.Controls.Add(this.lbSelectedFields);
            this.tpFields.Controls.Add(this.lbAllFields);
            this.tpFields.Controls.Add(this.groupBoxOrders);
            this.tpFields.Controls.Add(this.btAllFieldLeft);
            this.tpFields.Controls.Add(this.btAllFieldRight);
            this.tpFields.Controls.Add(this.btFieldRight);
            this.tpFields.Controls.Add(this.btFieldLeft);
            this.tpFields.Controls.Add(this.label2);
            this.tpFields.Controls.Add(this.label1);
            this.tpFields.Location = new System.Drawing.Point(4, 22);
            this.tpFields.Name = "tpFields";
            this.tpFields.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpFields.Size = new System.Drawing.Size(735, 314);
            this.tpFields.TabIndex = 0;
            this.tpFields.Text = "Поля";
            this.tpFields.UseVisualStyleBackColor = true;
            // 
            // lbSelectedFields
            // 
            this.lbSelectedFields.Location = new System.Drawing.Point(328, 34);
            this.lbSelectedFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSelectedFields.MultiSelect = false;
            this.lbSelectedFields.Name = "lbSelectedFields";
            this.lbSelectedFields.Size = new System.Drawing.Size(232, 272);
            this.lbSelectedFields.TabIndex = 10;
            this.lbSelectedFields.UseCompatibleStateImageBehavior = false;
            this.lbSelectedFields.View = System.Windows.Forms.View.List;
            this.lbSelectedFields.SelectedIndexChanged += new System.EventHandler(this.lbSelectedFields_SelectedValueChanged);
            // 
            // lbAllFields
            // 
            this.lbAllFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAllFields.Location = new System.Drawing.Point(8, 33);
            this.lbAllFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAllFields.Name = "lbAllFields";
            this.lbAllFields.Size = new System.Drawing.Size(233, 271);
            this.lbAllFields.TabIndex = 1;
            this.lbAllFields.UseCompatibleStateImageBehavior = false;
            this.lbAllFields.View = System.Windows.Forms.View.List;
            this.lbAllFields.SelectedIndexChanged += new System.EventHandler(this.lbAllFields_SelectedIndexChanged);
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.Controls.Add(this.radioButtonNo);
            this.groupBoxOrders.Controls.Add(this.radioButtonDesc);
            this.groupBoxOrders.Controls.Add(this.radioButtonAsc);
            this.groupBoxOrders.Location = new System.Drawing.Point(564, 34);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(117, 101);
            this.groupBoxOrders.TabIndex = 9;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Порядок";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(6, 67);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(106, 17);
            this.radioButtonNo.TabIndex = 0;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Не сортировать";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Location = new System.Drawing.Point(6, 44);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(88, 17);
            this.radioButtonDesc.TabIndex = 0;
            this.radioButtonDesc.Text = "Убывающий";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            this.radioButtonDesc.CheckedChanged += new System.EventHandler(this.radioButtonDesc_CheckedChanged);
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Location = new System.Drawing.Point(7, 21);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(102, 17);
            this.radioButtonAsc.TabIndex = 0;
            this.radioButtonAsc.Text = "Возрастающий";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            this.radioButtonAsc.CheckedChanged += new System.EventHandler(this.radioButtonAsc_CheckedChanged);
            // 
            // btAllFieldLeft
            // 
            this.btAllFieldLeft.Location = new System.Drawing.Point(247, 263);
            this.btAllFieldLeft.Name = "btAllFieldLeft";
            this.btAllFieldLeft.Size = new System.Drawing.Size(76, 42);
            this.btAllFieldLeft.TabIndex = 2;
            this.btAllFieldLeft.Text = "<<";
            this.btAllFieldLeft.UseVisualStyleBackColor = true;
            this.btAllFieldLeft.Click += new System.EventHandler(this.btAllFieldLeft_Click);
            // 
            // btAllFieldRight
            // 
            this.btAllFieldRight.Location = new System.Drawing.Point(247, 217);
            this.btAllFieldRight.Name = "btAllFieldRight";
            this.btAllFieldRight.Size = new System.Drawing.Size(76, 42);
            this.btAllFieldRight.TabIndex = 2;
            this.btAllFieldRight.Text = ">>";
            this.btAllFieldRight.UseVisualStyleBackColor = true;
            this.btAllFieldRight.Click += new System.EventHandler(this.btAllFieldRight_Click);
            // 
            // btFieldRight
            // 
            this.btFieldRight.Location = new System.Drawing.Point(248, 119);
            this.btFieldRight.Name = "btFieldRight";
            this.btFieldRight.Size = new System.Drawing.Size(75, 42);
            this.btFieldRight.TabIndex = 2;
            this.btFieldRight.Text = ">";
            this.btFieldRight.UseVisualStyleBackColor = true;
            this.btFieldRight.Click += new System.EventHandler(this.btFieldRight_Click);
            // 
            // btFieldLeft
            // 
            this.btFieldLeft.Location = new System.Drawing.Point(248, 168);
            this.btFieldLeft.Name = "btFieldLeft";
            this.btFieldLeft.Size = new System.Drawing.Size(75, 42);
            this.btFieldLeft.TabIndex = 2;
            this.btFieldLeft.Text = "<";
            this.btFieldLeft.UseVisualStyleBackColor = true;
            this.btFieldLeft.Click += new System.EventHandler(this.btFieldLeft_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Все поля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбраные поля";
            // 
            // tpConditions
            // 
            this.tpConditions.Controls.Add(this.dpExpression);
            this.tpConditions.Controls.Add(this.label6);
            this.tpConditions.Controls.Add(this.label5);
            this.tpConditions.Controls.Add(this.label4);
            this.tpConditions.Controls.Add(this.label3);
            this.tpConditions.Controls.Add(this.btAdd);
            this.tpConditions.Controls.Add(this.btDelete);
            this.tpConditions.Controls.Add(this.cbConnective);
            this.tpConditions.Controls.Add(this.cbExpression);
            this.tpConditions.Controls.Add(this.cbFilter);
            this.tpConditions.Controls.Add(this.cbNameField);
            this.tpConditions.Controls.Add(this.lvConditions);
            this.tpConditions.Location = new System.Drawing.Point(4, 22);
            this.tpConditions.Name = "tpConditions";
            this.tpConditions.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpConditions.Size = new System.Drawing.Size(735, 314);
            this.tpConditions.TabIndex = 1;
            this.tpConditions.Text = "Условия";
            this.tpConditions.UseVisualStyleBackColor = true;
            this.tpConditions.Click += new System.EventHandler(this.tpConditions_Click);
            // 
            // dpExpression
            // 
            this.dpExpression.CustomFormat = "yyyy-MM-dd";
            this.dpExpression.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpExpression.Location = new System.Drawing.Point(428, 249);
            this.dpExpression.Name = "dpExpression";
            this.dpExpression.Size = new System.Drawing.Size(241, 20);
            this.dpExpression.TabIndex = 4;
            this.dpExpression.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Связка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выражение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Критерий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя поля";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(538, 276);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(92, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(636, 276);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(92, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cbConnective
            // 
            this.cbConnective.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnective.Enabled = false;
            this.cbConnective.FormattingEnabled = true;
            this.cbConnective.Items.AddRange(new object[] {
            "OR",
            "AND"});
            this.cbConnective.Location = new System.Drawing.Point(677, 245);
            this.cbConnective.Name = "cbConnective";
            this.cbConnective.Size = new System.Drawing.Size(52, 21);
            this.cbConnective.TabIndex = 1;
            // 
            // cbExpression
            // 
            this.cbExpression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExpression.Location = new System.Drawing.Point(429, 246);
            this.cbExpression.Name = "cbExpression";
            this.cbExpression.Size = new System.Drawing.Size(241, 21);
            this.cbExpression.TabIndex = 1;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(346, 249);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(77, 21);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbNameField
            // 
            this.cbNameField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameField.FormattingEnabled = true;
            this.cbNameField.Location = new System.Drawing.Point(107, 249);
            this.cbNameField.Name = "cbNameField";
            this.cbNameField.Size = new System.Drawing.Size(233, 21);
            this.cbNameField.TabIndex = 1;
            this.cbNameField.SelectedIndexChanged += new System.EventHandler(this.cbNameField_SelectedIndexChanged);
            // 
            // lvConditions
            // 
            this.lvConditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnFilter,
            this.columnValue,
            this.columnConnective});
            this.lvConditions.FullRowSelect = true;
            this.lvConditions.GridLines = true;
            this.lvConditions.Location = new System.Drawing.Point(6, 6);
            this.lvConditions.MultiSelect = false;
            this.lvConditions.Name = "lvConditions";
            this.lvConditions.Size = new System.Drawing.Size(723, 208);
            this.lvConditions.TabIndex = 0;
            this.lvConditions.UseCompatibleStateImageBehavior = false;
            this.lvConditions.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Имя поля";
            this.columnName.Width = 231;
            // 
            // columnFilter
            // 
            this.columnFilter.Text = "Критерий";
            this.columnFilter.Width = 89;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Значение";
            this.columnValue.Width = 270;
            // 
            // columnConnective
            // 
            this.columnConnective.Text = "Связка";
            this.columnConnective.Width = 128;
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.dgvResult);
            this.tpResult.Location = new System.Drawing.Point(4, 22);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpResult.Size = new System.Drawing.Size(735, 314);
            this.tpResult.TabIndex = 3;
            this.tpResult.Text = "Результат";
            this.tpResult.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(7, 7);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(722, 301);
            this.dgvResult.TabIndex = 0;
            // 
            // btWatchQuery
            // 
            this.btWatchQuery.Enabled = false;
            this.btWatchQuery.Location = new System.Drawing.Point(340, 357);
            this.btWatchQuery.Name = "btWatchQuery";
            this.btWatchQuery.Size = new System.Drawing.Size(197, 23);
            this.btWatchQuery.TabIndex = 3;
            this.btWatchQuery.Text = "Просмотр SQL";
            this.btWatchQuery.UseVisualStyleBackColor = true;
            this.btWatchQuery.Click += new System.EventHandler(this.btWatchQuery_Click);
            // 
            // btExecQuery
            // 
            this.btExecQuery.Enabled = false;
            this.btExecQuery.Location = new System.Drawing.Point(544, 357);
            this.btExecQuery.Name = "btExecQuery";
            this.btExecQuery.Size = new System.Drawing.Size(197, 23);
            this.btExecQuery.TabIndex = 4;
            this.btExecQuery.Text = "Выполнить запрос";
            this.btExecQuery.UseVisualStyleBackColor = true;
            this.btExecQuery.Click += new System.EventHandler(this.btExecQuery_Click);
            // 
            // NSTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 384);
            this.Controls.Add(this.btExecQuery);
            this.Controls.Add(this.btWatchQuery);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NSTD";
            this.Text = "Новый запрос";
            this.tabControl1.ResumeLayout(false);
            this.tpFields.ResumeLayout(false);
            this.tpFields.PerformLayout();
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            this.tpConditions.ResumeLayout(false);
            this.tpConditions.PerformLayout();
            this.tpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFields;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.Button btAllFieldLeft;
        private System.Windows.Forms.Button btAllFieldRight;
        private System.Windows.Forms.Button btFieldRight;
        private System.Windows.Forms.Button btFieldLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConditions;
        private System.Windows.Forms.DateTimePicker dpExpression;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cbConnective;
        private System.Windows.Forms.ComboBox cbExpression;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbNameField;
        private System.Windows.Forms.ListView lvConditions;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnFilter;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.ColumnHeader columnConnective;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.ListView lbAllFields;
        private System.Windows.Forms.ListView lbSelectedFields;
        private System.Windows.Forms.Button btWatchQuery;
        private System.Windows.Forms.Button btExecQuery;
    }
}

