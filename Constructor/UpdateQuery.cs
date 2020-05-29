using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom2
{
    public class UpdateQuery
    {
        private TableInDiagram _table;
        private List<List<string>> _expression;
        private string _where;
        private string _orderBy;
        private string _limit;
        private bool _low;
        private bool _ignore;

        public UpdateQuery()
        {
            Table = null;
            Expression = new List<List<string>>();
            Where = "";
            OrderBy = "";
            Limit = "";
        }

        public TableInDiagram Table { get => _table; set => _table = value; }
        /// <summary>
        /// Список полей, состоящий из имени / запроса СЕЛЕКТ, алиаса, значения / запроса СЕЛЕКТ
        /// </summary>
        public List<List<string>> Expression { get => _expression; set => _expression = value; }
        public string Where { get => _where; set => _where = value; }
        public string OrderBy { get => _orderBy; set => _orderBy = value; }
        public string Limit { get => _limit; set => _limit = value; }
        public bool Low { get => _low; set => _low = value; }
        public bool Ignore { get => _ignore; set => _ignore = value; }

        public string CreateUpdateQuery()
        {
            string query = "";
            string tableRef = "";
            string assigment = "";
            string where = "";

            foreach (List<string> row in Expression)
            {
                // Если по имени поля
                if (!row[0].ToUpper().Contains("SELECT"))
                {
                    tableRef += (tableRef != "" ? "," : "") + row[0] + (row[1] != "" ? " AS " + row[1] : "");
                    if (row[2] != "")
                        assigment += (assigment != "" ? "," : "") + (row[1] != "" ? row[1] : row[0]) + " = " + row[2];
                }
                //Если подзапрос
                else 
                {
                    
                }
            }
            query = string.Format("UPDATE {3} {4} \n{0} \nSET\n{1} \n{2}", tableRef, assigment, where == "" ? "" : "WHERE",
                Ignore ? "IGNORE" : "", Low ? "LOW_PRIORITY" : "");
            return query;
        }
    }
}
