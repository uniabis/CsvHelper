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
CanRead([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Determines if the member for the ``CsvHelper.Configuration.MemberMap`` can be read.
CanRead([MemberReferenceMap](/api/CsvHelper.Configuration/MemberReferenceMap)) | Determines if the member for the ``CsvHelper.Configuration.MemberReferenceMap`` can be read.
Dispose() | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
EnumerateRecords&lt;T&gt;(T) | Enumerates the records hydrating the given record instance with row data. The record instance is re-used and not cleared on each enumeration. This only works for streaming rows. If any methods are called on the projection that force the evaluation of the IEnumerable, such as ToList(), the entire list will contain the same instance of the record, which is the last row.
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
GetFieldIndex([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Gets the index of the field at name if found.
GetFieldIndex([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Gets the index of the field at name if found.
GetRecord&lt;T&gt;() | Gets the record converted into ``System.Type`` T.
GetRecord&lt;T&gt;(T) | Get the record converted into ``System.Type`` T.
GetRecord([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets the record.
GetRecords&lt;T&gt;() | Gets all the records in the CSV file and converts each to ``System.Type`` T. The Read method should not be used when using this.
GetRecords&lt;T&gt;(T) | Gets all the records in the CSV file and converts each to ``System.Type`` T. The read method should not be used when using this.
GetRecords([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets all the records in the CSV file and converts each to ``System.Type`` T. The Read method should not be used when using this.
Read() | Advances the reader to the next record. This will not read headers. You need to call ``CsvHelper.CsvReader.Read`` then ``CsvHelper.CsvReader.ReadHeader`` for the headers to be read.
ReadAsync() | Advances the reader to the next record. This will not read headers. You need to call ``CsvHelper.CsvReader.ReadAsync`` then ``CsvHelper.CsvReader.ReadHeader`` for the headers to be read.
ReadHeader() | Reads the header record without reading the first row.
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
ValidateHeader&lt;T&gt;() | Validates the header. A header is bad if all the mapped members don't match. If the header is not valid, a ``CsvHelper.ValidationException`` will be thrown.
ValidateHeader([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Validates the header. A header is bad if all the mapped members don't match. If the header is not valid, a ``CsvHelper.ValidationException`` will be thrown.
