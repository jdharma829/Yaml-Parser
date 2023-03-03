namespace YamlParser.Models
{
    public class QueryParameterInfo
    {
        public ColumnType Type { get; set; }

        public bool? IsArray { get; set; }

        public string? DefaultValue { get; set; }
    }
}