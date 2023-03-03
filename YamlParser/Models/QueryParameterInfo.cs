namespace YamlParser.Models;

public class QueryParameterInfo
{
    //protected void CheckJSON(ref dynamic prop, dynamic value)
    //{
    //    if (value is String)
    //    {
    //        try
    //        {
    //            prop = JsonNode.Parse(value);
    //        }
    //        catch (Exception e)
    //        {
    //            prop = value;
    //        }
    //    }
    //    else
    //        prop = value;
    //}

    public ColumnType Type { get; set; }

    public bool? IsArray { get; set; }

    public string? DefaultValue { get; set; }

    //private dynamic _defaultValue;
    //public dynamic? DefaultValue
    //{
    //    get { return _defaultValue; }
    //    set => CheckJSON(ref _defaultValue, value);
    //}
}