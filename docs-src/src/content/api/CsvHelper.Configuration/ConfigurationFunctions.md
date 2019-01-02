# ConfigurationFunctions Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Holds the default callback methods for delegate members of ``CsvHelper.Configuration.Configuration`` .

```cs
public static class ConfigurationFunctions : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> ConfigurationFunctions

## Methods
&nbsp; | &nbsp;
- | -
BadDataFound([ReadingContext](/api/CsvHelper/ReadingContext)) | 
GetConstructor([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
HeaderValidated([Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ReadingContext](/api/CsvHelper/ReadingContext)) | 
MissingFieldFound([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ReadingContext](/api/CsvHelper/ReadingContext)) | 
PrepareHeaderForMatch([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
ReadingExceptionOccurred([CsvHelperException](/api/CsvHelper/CsvHelperException)) | 
ShouldQuote([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [WritingContext](/api/CsvHelper/WritingContext)) | 
ShouldSkipRecord([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | 
ShouldUseConstructorParameters([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
