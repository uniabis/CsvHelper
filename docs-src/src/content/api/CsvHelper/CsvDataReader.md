# CsvDataReader Class

Namespace: [CsvHelper](/api/CsvHelper)

Provides a means of reading a CSV file forward-only by using CsvReader.

```cs
[System.Reflection.DefaultMemberAttribute]
public class CsvDataReader : IDataReader, IDisposable, IDataRecord
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> CsvDataReader

## Constructors
&nbsp; | &nbsp;
- | -
CsvDataReader([CsvReader](/api/CsvHelper/CsvReader)) | Initializes a new instance of the ``CsvHelper.CsvDataReader`` class.

## Properties
&nbsp; | &nbsp;
- | -
Depth | Gets a value indicating the depth of nesting for the current row.
FieldCount | Gets the number of columns in the current row.
IsClosed | Gets a value indicating whether the data reader is closed.
this[[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets the column with the specified index.
this[[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)] | Gets the column with the specified name.
RecordsAffected | Gets the number of rows changed, inserted, or deleted by execution of the SQL statement.

## Methods
&nbsp; | &nbsp;
- | -
Close() | 
Dispose() | 
GetBoolean([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetByte([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetBytes([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64), [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetChar([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetChars([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64), [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetData([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetDataTypeName([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetDateTime([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetDecimal([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetDouble([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetFieldType([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetFloat([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetGuid([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetInt16([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetInt32([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetInt64([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetName([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetOrdinal([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
GetSchemaTable() | 
GetString([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetValue([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetValues([Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | 
IsDBNull([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
NextResult() | 
Read() | 
