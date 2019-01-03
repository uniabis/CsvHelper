# Factory Class

Namespace: [CsvHelper](/api/CsvHelper)

Creates CsvHelper classes.

```cs
public class Factory : IFactory
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> Factory

## Methods
&nbsp; | &nbsp;
- | -
CreateClassMapBuilder&lt;T&gt;() | Access point for fluent interface to dynamically build a ``CsvHelper.Configuration.ClassMap`1``
CreateParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates an ``CsvHelper.IParser`` .
CreateParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader)) | Creates an ``CsvHelper.IParser`` .
CreateReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates an ``CsvHelper.IReader`` .
CreateReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader)) | Creates an ``CsvHelper.IReader`` .
CreateReader([IParser](/api/CsvHelper/IParser)) | Creates an ``CsvHelper.IReader`` .
CreateWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates an ``CsvHelper.IWriter`` .
CreateWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)) | Creates an ``CsvHelper.IWriter`` .
