using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom2.Constructor
{
    public class DeleteQuery
    {
        

        public bool LowPriotity { get; set; }
        public bool Quick { get; set; }
        public List<string> TableNames { get; set; }
        public string Where { get; set; }
        public string Limit { get; set; }

        public string OrderBy { get; set; }
        public DeleteQuery()
        {
            TableNames = new List<string>();
        }
        public string GenerateDeleteQuery()
        {
            string tableNames = "";
            string query;
            if (TableNames.Count == 1)
            {

                query = string.Format("DELETE{0}{1}\nFROM{2}{3}{4}{5}",
                    (LowPriotity != false ? "\nLOW_PRIORITY" : ""),
                    (Quick != false ? "\nQUICK" : ""),
                    TableNames[0],
                    (Where != "" ? "\nWhere "+Where : ""),
                    (OrderBy != "" ? "\n"+OrderBy : ""),
                    (Limit != "" ? "\nLimit "+Limit : ""));
            }
            else
            {
                query = string.Format("{0}{1}\nFROM{2}{3}}",
                    (LowPriotity != false ? "\nLOW_PRIORITY" : ""),
                    (Quick != false ? "\nQUICK" : ""),
                    "\n"+tableNames,
                    (Where != null ? "\nWhere " + Where : ""));
            }
            return query;
        }
    }
}
