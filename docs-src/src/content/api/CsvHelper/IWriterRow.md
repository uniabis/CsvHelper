# IWriterRow Interface

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to write a CSV row.

```cs
public interface IWriterRow : 
```

## Properties
&nbsp; | &nbsp;
- | -
Configuration | Gets or sets the configuration.
Context | Gets the writing context.

## Methods
&nbsp; | &nbsp;
- | -
WriteComment([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
WriteConvertedField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
WriteField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
WriteField([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 
WriteField([T](/api/CsvHelper/T)) | 
WriteField([T](/api/CsvHelper/T), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
WriteField([T](/api/CsvHelper/T)) | 
WriteHeader() | 
WriteHeader([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
WriteRecord([T](/api/CsvHelper/T)) | 
