using Newtonsoft.Json.Linq;

namespace YamlParser
{
    public class QueryParameterInfo
    {
        public ColumnType Type { get; set; }

        public bool? IsArray { get; set; }

        public string? DefaultValue { get; set; }
    }
}