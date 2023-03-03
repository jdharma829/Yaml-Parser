namespace YamlParser.Models
{
    public class DBQuery
    {
        public struct ListQueryModeCode
        {
            public const string ListWithCount = "LC";
            public const string ListNoCount = "LNC";
            public const string Scalar = "S";
        }

        public string QueryName { get; set; }

        // this is a multi line SQL query with line feeds .
        public string QuerySql { get; set; }

        public string? Permissions { get; set; }

        // multiline value each line has one permission id
        public List<string> PermissionList { get; set; }

        //comma separated list of fields
        public string? DefaultSortOrder { get; set; }

        //multiline text
        public string? Description { get; set; }

        public string? ModeCode { get; set; }

        public Dictionary<string, QueryParameterInfo>? ParameterConfig { get; set; }

        public Dictionary<string, QueryColumnInfo>? ColumnConfig { get; set; }
    }
}
