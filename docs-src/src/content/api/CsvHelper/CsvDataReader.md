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
Close() | Closes the ``System.Data.IDataReader`` Object.
Dispose() | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
GetBoolean([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the value of the specified column as a Boolean.
GetByte([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the 8-bit unsigned integer value of the specified column.
GetBytes([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64), [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Reads a stream of bytes from the specified column offset into the buffer as an array, starting at the given buffer offset.
GetChar([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the character value of the specified column.
GetChars([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64), [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Reads a stream of characters from the specified column offset into the buffer as an array, starting at the given buffer offset.
GetData([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Returns an ``System.Data.IDataReader`` for the specified column ordinal.
GetDataTypeName([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the data type information for the specified field.
GetDateTime([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the date and time data value of the specified field.
GetDecimal([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the fixed-position numeric value of the specified field.
GetDouble([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the double-precision floating point number of the specified field.
GetFieldType([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the ``System.Type`` information corresponding to the type of ``System.Object`` that would be returned from ``System.Data.IDataRecord.GetValue(System.Int32)`` .
GetFloat([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the single-precision floating point number of the specified field.
GetGuid([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Returns the GUID value of the specified field.
GetInt16([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the 16-bit signed integer value of the specified field.
GetInt32([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the 32-bit signed integer value of the specified field.
GetInt64([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the 64-bit signed integer value of the specified field.
GetName([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the name for the field to find.
GetOrdinal([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Return the index of the named field.
GetSchemaTable() | Returns a ``System.Data.DataTable`` that describes the column metadata of the ``System.Data.IDataReader`` .
GetString([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the string value of the specified field.
GetValue([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Return the value of the specified field.
GetValues([Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | Populates an array of objects with the column values of the current record.
IsDBNull([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Return whether the specified field is set to null.
NextResult() | Advances the data reader to the next result, when reading the results of batch SQL statements.
Read() | Advances the ``System.Data.IDataReader`` to the next record.
