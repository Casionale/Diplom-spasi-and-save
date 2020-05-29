namespace Diplom2
{
    public struct Relationship
    {
        public string tableName;
        public string columnName;
        public string constraintName;
        public string referencedTableName;
        public string referencedColumnName;

        public Relationship(string tableName, string columnName, string constraintName,
                                string referencedTableName, string referencedColumnName)
        {
            this.tableName = tableName;
            this.columnName = columnName;
            this.constraintName = constraintName;
            this.referencedTableName = referencedTableName;
            this.referencedColumnName = referencedColumnName;
        }
    }
}