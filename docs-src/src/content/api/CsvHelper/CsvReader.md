# CsvReader Class

Namespace: [CsvHelper](/api/CsvHelper)

Reads data that was parsed from ``CsvHelper.IParser`` .

```cs
[System.Reflection.DefaultMemberAttribute]
public class CsvReader : IReader, IReaderRow, IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> CsvReader

## Constructors
&nbsp; | &nbsp;
- | -
CsvReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader)) | Creates a new CSV reader using the given ``System.IO.TextReader`` .
CsvReader([IParser](/api/CsvHelper/IParser)) | Creates a new CSV reader using the given ``CsvHelper.IParser`` .
CsvReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new CSV reader using the given ``System.IO.TextReader`` .
CsvReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates a new CSV reader using the given ``System.IO.TextReader`` and ``CsvHelper.Configuration.Configuration`` and ``CsvHelper.CsvParser`` as the default parser.
CsvReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new CSV reader using the given ``System.IO.TextReader`` .

## Properties
&nbsp; | &nbsp;
- | -
Configuration | Gets the configuration.
Context | Gets the reading context.
this[[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets the raw field at position (column) index.
this[[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)] | Gets the raw field at position (column) name.
this[[String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets the raw field at position (column) name.
Parser | Gets the parser.

## Methods
&nbsp; | &nbsp;
- | -
CanRead([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
CanRead([MemberReferenceMap](/api/CsvHelper.Configuration/MemberReferenceMap)) | 
Dispose() | 
EnumerateRecords([T](/api/CsvHelper/T)) | 
GetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
GetFieldIndex([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 
GetFieldIndex([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 
GetRecord() | 
GetRecord([T](/api/CsvHelper/T)) | 
GetRecord([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
GetRecords() | 
GetRecords([T](/api/CsvHelper/T)) | 
GetRecords([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
Read() | 
ReadAsync() | 
ReadHeader() | 
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)) | 
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)) | 
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)) | 
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)) | 
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)) | 
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)) | 
TryGetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [T&](/api/CsvHelper/T&)) | 
TryGetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [T&](/api/CsvHelper/T&)) | 
TryGetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [T&](/api/CsvHelper/T&)) | 
TryGetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [T&](/api/CsvHelper/T&)) | 
TryGetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [T&](/api/CsvHelper/T&)) | 
TryGetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [T&](/api/CsvHelper/T&)) | 
TryGetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [T&](/api/CsvHelper/T&)) | 
TryGetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [T&](/api/CsvHelper/T&)) | 
TryGetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [T&](/api/CsvHelper/T&)) | 
ValidateHeader() | 
ValidateHeader([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
