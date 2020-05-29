using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2
{
    public class SelectQuery
    {
        public List<string> selectExpressions; //Список полей
        public List<string> alias;
        public string from; // Из какой таблицы
        public List<string> tableReferences; // Связи таблиц джоинами
        public string whereDefinition; // условие
        public string groupBy; // Группировка
        public string having; // Условие троенных функций
        public string orderBy; // СОртировка
        public string limit; // Лимит
        public bool distinct;

        public List<string> tableNames;
        public List<Relationship> useRelationships;
        public List<string> useTypesRelationships;

        private List<string> usesHaving;

        public SelectQuery()
        {
            selectExpressions = new List<string>();
            alias = new List<string>();
            from = "";
            tableReferences = new List<string>();
            whereDefinition = "";
            groupBy = "";
            having = "";
            orderBy = "";
            limit = "";
            tableNames = new List<string>();
            useRelationships = new List<Relationship>();
            useTypesRelationships = new List<string>();
            distinct = false;
        }

        public string generateQuery() 
        {
            string selectExpression = "";
            for (int i = 0; i < selectExpressions.Count; i++)
            {
                selectExpression += selectExpressions[i]
                    + (alias[i] == "" ? "" : " AS '"+alias[i]+"'")
                    + (i == selectExpressions.Count - 1 ? "\n" : ",\n");
            }

            for (int i = 0; i < usesHaving.Count; i++)
            {
                selectExpression += ",\n" + usesHaving[i];
            }
            
            from = "";
            if (useRelationships.Count != 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    from += "`" + useRelationships[i].referencedTableName + "`" +
                        "\n" + useTypesRelationships[i] +
                        " `" + useRelationships[i].tableName + "`\nON " +
                        "`" + useRelationships[i].referencedTableName + "`.`" + useRelationships[i].referencedColumnName + "` = " +
                        "`" + useRelationships[i].tableName + "`.`" + useRelationships[i].columnName + "`";
                }
                for (int i = 1; i < useRelationships.Count; i++)
                {
                    from += "\n " + useTypesRelationships[i] + " " +
                        "`" + useRelationships[i].referencedTableName + "`\nON " +
                        "`" + useRelationships[i].tableName + "`.`" + useRelationships[i].columnName + "` = " +
                        "`" + useRelationships[i].referencedTableName + "`.`" + useRelationships[i].referencedColumnName + "`";
                }
            }
            else
            {
                from = selectExpression.Substring(0, selectExpression.IndexOf("."));
            }
            if (limit != "" && limit != null)
                limit = "\nLIMIT " + limit;
            if (orderBy != "" && orderBy != null)
                orderBy = "\n" + orderBy;
            if (groupBy != "" && groupBy != null)
                groupBy = "\nGROUP BY " + groupBy;

            string query = string.Format("SELECT {2} \n{0} \nFROM {1} \n{3} \n{4} {5} {6} {7}", 
                            selectExpression, from, distinct ? "DISTINCT ":"", whereDefinition, groupBy, having, orderBy, limit);
            return query;
        }

        public void generateConditions(DataGridView dgv)
        {
            string where = "";
            string orderBy = "";
            string having = "";
            string groupBy = "";
            usesHaving = new List<string>();
            whereDefinition = "";
            this.having = "";
            foreach (DataGridViewRow dgvr in dgv.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    try
                    {
                        string field = dgvr.Cells[0].Value.ToString();
                        string whereField = dgvr.Cells[1].Value.ToString();
                        string groupType = dgvr.Cells[2].Value.ToString();
                        bool group = (bool)dgvr.Cells[5].Value;
                        string havingType = dgvr.Cells[3].Value.ToString();
                        string whereHaving = dgvr.Cells[4].Value.ToString();

                        if (whereField != "")
                        {
                            where += where != "" ? " AND " : "";
                            where += field + " " + whereField;
                        }

                        if (groupType != "NONE")
                        {
                            orderBy += orderBy != "" ? ",  " : "";
                            orderBy += field + " " + groupType;
                        }

                        if (havingType != "NONE" && whereHaving != "")
                        {
                            having += having != "" ? " AND " : "";
                            having += havingType + "(" + field + ") " + whereHaving;
                            usesHaving.Add(havingType + "(" + field + ") ");
                        }

                        if (group)
                        {
                            groupBy += groupBy != "" ? ", " : "";
                            groupBy += field;
                        }

                        whereDefinition = where != "" ? "WHERE " + where : "";
                        this.orderBy = orderBy != "" ? " ORDER BY " + orderBy : "";
                        this.having = having != "" ? " HAVING " + having : "";
                        this.groupBy = groupBy;
                    }
                    catch (NullReferenceException){}
                }
            }
        }

        public void generatedLimitAndDistinct(string limit, bool isDistinct)
        {
            this.limit = limit;
            this.distinct = isDistinct;
        }
    }
}
