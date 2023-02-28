using Newtonsoft.Json.Linq;

namespace YamlParser
{
    public class DBQuery
    {
        //protected void CheckJSON(ref dynamic prop, dynamic value)
        //{
        //    if (value is String)
        //    {
        //        try
        //        {
        //            prop = JObject.Parse(value);
        //        }
        //        catch (Exception e)
        //        {
        //            prop = value;

        //        }
        //    }
        //    else
        //        prop = value;
        //}

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

        //private dynamic? _parameterConfig, _columnConfig;

        ////json
        //public dynamic? ParameterConfig
        //{
        //    get { return _parameterConfig; }
        //    set { CheckJSON(ref _parameterConfig, value); }
        //}

        ////json
        //public dynamic? ColumnConfig
        //{
        //    get { return _columnConfig; }
        //    set { CheckJSON(ref _columnConfig, value); }
        //}
    }
}
