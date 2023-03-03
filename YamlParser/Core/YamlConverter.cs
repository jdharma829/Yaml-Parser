using System.Text.Json;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace YamlParser.Core;

public static class YamlConverter
{
    public static ISerializer DefaultSerializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .DisableAliases()
            //.ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
            .WithTypeConverter(new TypeConverter())
            .WithTypeInspector(i => new TypeInspector(i))
            .Build();

    public static IDeserializer DefaultDeserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .WithTypeConverter(new TypeConverter())
            .WithTypeInspector(i => new TypeInspector(i))
            .Build();

    public static string Serialize(object obj, ISerializer? serializer = null)
    {
        serializer ??= DefaultSerializer;
        return serializer.Serialize(obj);
    }

    public static string SerializeJson(string json, ISerializer? serializer = null, JsonSerializerOptions jsonSerializerOptions = null)
    {
        serializer ??= DefaultSerializer;
        return serializer.Serialize(JsonSerializer.Deserialize<JsonDocument>(json, jsonSerializerOptions));
    }

    public static T Deserialize<T>(string yaml, IDeserializer? deserializer = null)
    {
        deserializer ??= DefaultDeserializer;
        return deserializer.Deserialize<T>(yaml);
    }
}