// See https://aka.ms/new-console-template for more information
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using YamlParser;

//Dictionary<string, QueryParameterInfo> QueryParameterInfos = new Dictionary<string, QueryParameterInfo>();
//QueryParameterInfos.Add("one", new QueryParameterInfo() { Type = ColumnType.Int, IsArray = false, DefaultValue = "10" });
//QueryParameterInfos.Add("two", new QueryParameterInfo() { Type = ColumnType.String, IsArray = false, DefaultValue = "20" });
//QueryParameterInfos.Add("three", new QueryParameterInfo() { Type = ColumnType.JSON, IsArray = false, DefaultValue = @"{ ""name"": ""Dharma"", ""place"": ""Albuquerque"" }" });

//Dictionary<string, string>? QueryParameterValues = new Dictionary<string, string>();
//QueryParameterValues.Add("param 1", "param value 1");
//QueryParameterValues.Add("param 2", "param value 2");

//Dictionary<string, QueryColumnInfo> QueryColumnInfos = new Dictionary<string, QueryColumnInfo>();
//QueryColumnInfos.Add("five", new QueryColumnInfo() { Type = ColumnType.Int, LOVType = "LOV", SubQueryName = "Sub Query Name 1", SubQueryParameters = QueryParameterValues });
//QueryColumnInfos.Add("four", new QueryColumnInfo() { Type = ColumnType.String, LOVType = "LOV", SubQueryName = "Sub Query Name 2", SubQueryParameters = QueryParameterValues });

//DBQuery query = new DBQuery()
//{
//    QueryName = "Query Name",
//    QuerySql = "Select * From Employees",
//    Permissions = null,
//    PermissionList = new List<string>() { "first level permission", "second level permission" },
//    DefaultSortOrder = "name, price",
//    Description = "Description Value Description Value Description Value Description \n Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value",
//    ModeCode = null,
//    ParameterConfig = QueryParameterInfos,
//    ColumnConfig = QueryColumnInfos
//};

//var updatedyaml = YamlConvert.SerializeObject(query);

//Console.WriteLine(updatedyaml);

//DBQuery result = YamlConvert.DeserializeObject<DBQuery>(updatedyaml);

string yamlContent = File.ReadAllText("yaml-sample.yaml");

Console.WriteLine(yamlContent);

DBQuery result = YamlConvert.DeserializeObject<DBQuery>(yamlContent);

Console.Read();
