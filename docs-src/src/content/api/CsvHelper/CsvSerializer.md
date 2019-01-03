# CsvSerializer Class

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to serialize data into a CSV file.

```cs
public class CsvSerializer : ISerializer, IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> CsvSerializer

## Constructors
&nbsp; | &nbsp;
- | -
CsvSerializer([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)) | Creates a new serializer using the given ``System.IO.TextWriter`` .
CsvSerializer([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new serializer using the given ``System.IO.TextWriter`` .
CsvSerializer([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates a new serializer using the given ``System.IO.TextWriter`` and ``CsvHelper.Configuration.Configuration`` .
CsvSerializer([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new serializer using the given ``System.IO.TextWriter`` and ``CsvHelper.Configuration.Configuration`` .

## Properties
&nbsp; | &nbsp;
- | -
Configuration | Gets the configuration.
Context | Gets the writing context.

## Methods
&nbsp; | &nbsp;
- | -
Dispose() | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
Write([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | Writes a record to the CSV file.
WriteAsync([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | Writes a record to the CSV file.
WriteLine() | Writes a new line to the CSV file.
WriteLineAsync() | Writes a new line to the CSV file.
