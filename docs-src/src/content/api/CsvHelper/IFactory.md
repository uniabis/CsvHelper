# IFactory Interface

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to create CsvHelper classes.

```cs
public interface IFactory : 
```

## Methods
&nbsp; | &nbsp;
- | -
CreateClassMapBuilder&lt;T&gt;() | Provides a fluent interface for dynamically creating ``CsvHelper.Configuration.ClassMap`1`` s
CreateParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates an ``CsvHelper.IParser`` .
CreateParser([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader)) | Creates an ``CsvHelper.IParser`` .
CreateReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates an ``CsvHelper.IReader`` .
CreateReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader)) | Creates an ``CsvHelper.IReader`` .
CreateReader([IParser](/api/CsvHelper/IParser)) | Creates an ``CsvHelper.IReader`` .
CreateWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates an ``CsvHelper.IWriter`` .
CreateWriter([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)) | Creates an ``CsvHelper.IWriter`` .
