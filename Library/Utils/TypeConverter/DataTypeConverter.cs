using System;
using System.Collections.Generic;

namespace Genesis.Converter;

public class DataTypeConverter
{
    public Guid sla {get;set;}
    private static Dictionary<string, DataTypeStructure> types = new(){
        { "bigint", 
            new( "bigint", "int") },
        { "binary", 
            new("binary","byte[]") },
        { "bit", 
            new( "bit", "bool") },
        { "char", 
            new( "char", "string") },
        { "date", 
            new( "date", "System.DateTime") }, 
        { "datetime", 
            new( "datetime", "System.DateTime") }, 
        { "datetime2", 
            new( "datetime2", "System.DateTime") }, 
        { "datetimeoffset", 
            new( "datetimeoffset", "System.DateTimeOffset") }, 
        { "decimal", 
            new( "decimal", "decimal") },
        { "FILESTREAM attribute (varbinary(max))", 
            new( "FILESTREAM","byte[]") },
        { "float", 
            new( "float", "double") },
        { "image", 
            new("image", "byte[]") },
        { "int", 
            new( "int", "int") },
        { "money", 
            new( "money", "decimal") },
        { "nchar", 
            new( "nchar", "string") },
        { "ntext", 
            new( "ntext", "string") },
        { "numeric", 
            new( "numeric", "decimal") },
        { "nvarchar", 
            new( "nvarchar", "string") },
        { "real", 
            new( "real", "System.Single") },
        { "rowversion", 
            new("rowversion","byte[]") },
        { "smalldatetime", 
            new( "smalldatetime", "System.DateTime") },
        { "smallint", 
            new( "smallint", "int") },
        { "smallmoney", 
            new( "smallmoney", "decimal") },
        { "sql_variant", 
            new( "sql_variant", "Object") },
        { "text", 
            new( "text", "string") },
        { "time", 
            new( "time", "System.TimeSpan") },
        { "timestamp", 
            new("timestamp", "byte[]") },
        { "tinyint", 
            new( "tinyint", "byte") },
        { "uniqueidentifier", 
            new( "uniqueidentifier", "System.Guid") },
        { "varbinary", 
            new("varbinary", "byte[]") },
        { "varchar", 
            new( "varchar", "string") },
        { "xml", 
            new( "xml", "Xml") }
    };
    public static DataTypeStructure GetNetType (string type) 
        => types[type];
}