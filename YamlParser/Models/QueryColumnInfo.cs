namespace YamlParser.Models
{
    // TODO: MANOJ WIP . move meta data to table, so binding can be done ..or as a metadata column..
    public class QueryColumnInfo
    {

        //public string Name { get; set; }
        //should be enum - check from Dapper 
        public ColumnType Type { get; set; } // string, date, datetime, JSON, Guid, Integer, boolean, subQuery

        //indicates the LOVType for the column. applicable if Type = LOV
        public string? LOVType { get; set; }

        /// <summary>
        /// the name of the SubQuery from the listQuery table that should be used to populate the data of this column as an array
        /// </summary>
        public string? SubQueryName { get; set; } //applicable name of SubQuery, parameter of subquery should match the columns of currentRecord

        /// <summary>
        /// optional information for mapping columns of this query to the SubQuery. if this is not specified, the columnnames should match the subquery parameters if any
        /// </summary>
        public Dictionary<string, string>? SubQueryParameters { get; set; }

        //function to set default value..create a list of functions by type..e.g. date(), newguid().. time(), now(), fixed string no () at the end

    }

}
