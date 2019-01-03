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
GetField([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the raw field at position (column) index.
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Gets the raw field at position (column) name.
GetField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the raw field at position (column) name and the index instance of that field. The index is used when there are multiple columns with the same header name.
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the field converted to ``System.Object`` using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Gets the field converted to ``System.Object`` using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the field converted to ``System.Object`` using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Gets the field converted to ``System.Object`` using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Gets the field converted to ``System.Object`` using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Gets the field converted to ``System.Object`` using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField&lt;T&gt;([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the field converted to ``System.Type`` T at position (column) index.
GetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Gets the field converted to ``System.Type`` T at position (column) name.
GetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the field converted to ``System.Type`` T at position (column) name and the index instance of that field. The index is used when there are multiple columns with the same header name.
GetField&lt;T&gt;([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Gets the field converted to ``System.Type`` T at position (column) index using the given ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Gets the field converted to ``System.Type`` T at position (column) name using the given ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Gets the field converted to ``System.Type`` T at position (column) name and the index instance of that field. The index is used when there are multiple columns with the same header name.
GetField&lt;T, TConverter&gt;([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the field converted to ``System.Type`` T at position (column) index using the given ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField&lt;T, TConverter&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Gets the field converted to ``System.Type`` T at position (column) name using the given ``CsvHelper.TypeConversion.ITypeConverter`` .
GetField&lt;T, TConverter&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Gets the field converted to ``System.Type`` T at position (column) name and the index instance of that field. The index is used when there are multiple columns with the same header name.
GetRecord&lt;T&gt;() | Gets the record converted into ``System.Type`` T.
GetRecord&lt;T&gt;(T) | Get the record converted into ``System.Type`` T.
GetRecord([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets the record.
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), out [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) | Gets the field converted to ``System.Type`` T at position (column) index.
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), out [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) | Gets the field converted to ``System.Type`` T at position (column) name.
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), out [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) | Gets the field converted to ``System.Type`` T at position (column) name and the index instance of that field. The index is used when there are multiple columns with the same header name.
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), out [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) | Gets the field converted to ``System.Type`` T at position (column) index using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), out [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) | Gets the field converted to ``System.Type`` T at position (column) name using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), out [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)) | Gets the field converted to ``System.Type`` T at position (column) name using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField&lt;T&gt;([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) index.
TryGetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) name.
TryGetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) name and the index instance of that field. The index is used when there are multiple columns with the same header name.
TryGetField&lt;T&gt;([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) index using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) name using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField&lt;T&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) name using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField&lt;T, TConverter&gt;([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) index using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField&lt;T, TConverter&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) name using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
TryGetField&lt;T, TConverter&gt;([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), out [T](/api/CsvHelper/T)) | Gets the field converted to ``System.Type`` T at position (column) name using the specified ``CsvHelper.TypeConversion.ITypeConverter`` .
