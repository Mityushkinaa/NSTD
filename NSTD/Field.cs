using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSTD
{
    class Field
    {
        public string fieldName; //
        public string tableName;
        public string fieldType;
        public string translFN; //
        public string categoryName;
        public string order;

        public Field(string fieldName, string tableName, string fieldType, string translFN, string categoryName)
        {
            this.fieldName = fieldName;
            this.tableName = tableName;
            this.fieldType = fieldType;
            this.translFN = translFN;
            this.categoryName = categoryName;
        }

        public Field(string fieldName, string tableName, string fieldType, string translFN, string categoryName, string order)
        {
            this.fieldName = fieldName;
            this.tableName = tableName;
            this.fieldType = fieldType;
            this.translFN = translFN;
            this.categoryName = categoryName;
            this.order = order;
        }


    }
}
