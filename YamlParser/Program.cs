// See https://aka.ms/new-console-template for more information
using YamlParser;

//DBQuery query = new DBQuery()
//{
//    QueryName = "Query Name",
//    QuerySql = "Query Sql",
//    Permissions = null,
//    PermissionList = new List<string>() { "first level permission", "second level permission" },
//    DefaultSortOrder = "name, price",
//    Description = "Description Value Description Value Description Value Description \n Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value Description Value",
//    ModeCode = null,
//    ParameterConfig = @"{ ""name"": ""Dharma"", ""place"": ""Dharma"" }",
//    ColumnConfig = @"{ ""place"": ""Albuquerque"", ""address"": ""Albuquerque"" }"
//};

//var updatedyaml = YamlConvert.SerializeObject(query);

string yamlContent =  File.ReadAllText("yaml-sample.yaml");

Console.WriteLine(yamlContent);

DBQuery result = YamlConvert.DeserializeObject<DBQuery>(yamlContent);

Console.Read();
