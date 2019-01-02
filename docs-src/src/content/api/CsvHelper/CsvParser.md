# CsvParser Class

Namespace: [CsvHelper](/api/CsvHelper)

Parses a CSV file.

```cs
public class CsvParser : IParser, IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> CsvParser

## Constructors
&nbsp; | &nbsp;
- | -
CsvParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader)) | Creates a new parser using the given ``System.IO.TextReader`` .
CsvParser([IFieldReader](/api/CsvHelper/IFieldReader)) | Creates a new parser using the given ``CsvHelper.CsvParser.FieldReader`` .
CsvParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new parser using the given ``System.IO.TextReader`` .
CsvParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates a new parser using the given ``System.IO.TextReader`` and ``CsvHelper.CsvParser.Configuration`` .
CsvParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new parser using the given ``System.IO.TextReader`` and ``CsvHelper.CsvParser.Configuration`` .

## Properties
&nbsp; | &nbsp;
- | -
Configuration | Gets the configuration.
Context | Gets the reading context.
FieldReader | Gets the ``CsvHelper.CsvParser.FieldReader`` .

## Methods
&nbsp; | &nbsp;
- | -
Dispose() | 
Read() | 
ReadAsync() | 
