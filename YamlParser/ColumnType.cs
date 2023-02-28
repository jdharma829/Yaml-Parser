using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YamlParser
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColumnType
    {
        String,
        Boolean,
        Int,
        Date,
        DateTime,
        Time,
        Float,
        Double,
        Guid,
        JSON,
        SubQuery
    }
}
