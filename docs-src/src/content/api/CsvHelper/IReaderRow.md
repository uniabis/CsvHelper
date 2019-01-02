# IReaderRow Interface

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to read parsed data from a CSV file row.

```cs
[System.Reflection.DefaultMemberAttribute]
public interface IReaderRow : 
```

## Properties
&nbsp; | &nbsp;
- | -
Configuration | Gets or sets the configuration.
Context | Gets the reading context.
this[[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets the raw field at position (column) index.
this[[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)] | Gets the raw field at position (column) name.
this[[String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets the raw field at position (column) name.

## Methods
&nbsp; | &nbsp;
- | -
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
GetRecord() | 
GetRecord([T](/api/CsvHelper/T)) | 
GetRecord([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
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
