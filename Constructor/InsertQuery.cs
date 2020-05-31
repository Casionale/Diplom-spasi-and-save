using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom2
{
    public class InsertQuery
    {
        private TableInDiagram _table;
        private List<List<string>> _expression;
        private string _select = "";

        public InsertQuery()
        {
            Table = null;
            Expression = new List<List<string>>();
            Select = "";
        }

        public TableInDiagram Table { get => _table; set => _table = value; }
        public List<List<string>> Expression { get => _expression; set => _expression = value; }
        public string Select { get => _select; set => _select = value; }

        public string CreateInsertQuery()
        {
            string query = "";
            if (Select == "")
            {
                string colNames = "";
                string values = "";
                int num;
                double numD;
                foreach (List<string> field in Expression)
                {
                    colNames += (colNames != "" ? "," : "") + field[0].Substring(field[0].IndexOf(".")+1);
                    values += (values != "" ? "," : "") + (int.TryParse(field[1], out num) || double.TryParse(field[1], out numD)
                                                                ? field[1] : "'"+field[1]+"'");
                }
                query = string.Format("INSERT INTO `{0}`\n({1})\nVALUES ({2})", Table.nameTable, colNames, values);
            }
            else
            {
                query = string.Format("INSERT INTO {0} ({1}), VALUES ({2})", "", "", "");
            }
            return query;
        }
    }
}
