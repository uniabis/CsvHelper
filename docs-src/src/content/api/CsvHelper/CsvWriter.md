# CsvWriter Class

Namespace: [CsvHelper](/api/CsvHelper)

Used to write CSV files.

```cs
public class CsvWriter : IWriter, IWriterRow, IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> CsvWriter

## Constructors
&nbsp; | &nbsp;
- | -
CsvWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)) | Creates a new CSV writer using the given ``System.IO.TextWriter`` .
CsvWriter([ISerializer](/api/CsvHelper/ISerializer)) | Creates a new CSV writer using the given ``CsvHelper.ISerializer`` .
CsvWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new CSV writer using the given ``System.IO.TextWriter`` .
CsvWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates a new CSV writer using the given ``System.IO.TextWriter`` .
CsvWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new CSV writer using the given ``System.IO.TextWriter`` .

## Properties
&nbsp; | &nbsp;
- | -
Configuration | Gets the configuration.
Context | Gets the writing context.

## Methods
&nbsp; | &nbsp;
- | -
CanWrite([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
Dispose() | 
Flush() | 
FlushAsync() | 
GetTypeForRecord([T](/api/CsvHelper/T)) | 
NextRecord() | 
NextRecordAsync() | 
WriteComment([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
WriteConvertedField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
WriteDynamicHeader([IDynamicMetaObjectProvider](https://docs.microsoft.com/en-us/dotnet/api/system.dynamic.idynamicmetaobjectprovider)) | 
WriteField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
WriteField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 
WriteField([T](/api/CsvHelper/T)) | 
WriteField([T](/api/CsvHelper/T), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
WriteField([T](/api/CsvHelper/T)) | 
WriteHeader() | 
WriteHeader([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
WriteRecord([T](/api/CsvHelper/T)) | 
WriteRecords([IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)) | 
WriteRecords([IEnumerable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable`1)) | 
