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
BadDataFound([ReadingContext](/api/CsvHelper/ReadingContext)) | Throws a ``CsvHelper.BadDataException`` .
GetConstructor([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Returns the type's constructor with the most parameters. If two constructors have the same number of parameters, then there is no guarantee which one will be returned. If you have that situation, you should probably implement this function yourself.
HeaderValidated([Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ReadingContext](/api/CsvHelper/ReadingContext)) | Throws a ``CsvHelper.ValidationException`` if ``isValid`` is ``false`` .
MissingFieldFound([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [ReadingContext](/api/CsvHelper/ReadingContext)) | Throws a ``MissingFieldException`` .
PrepareHeaderForMatch([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Returns the ``header`` as given.
ReadingExceptionOccurred([CsvHelperException](/api/CsvHelper/CsvHelperException)) | Throws the given ``exception`` .
ShouldQuote([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [WritingContext](/api/CsvHelper/WritingContext)) | Returns true if the field contains a ``CsvHelper.Configuration.IWriterConfiguration.QuoteString`` , starts with a space, ends with a space, contains \r or \n, or contains the ``CsvHelper.Configuration.ISerializerConfiguration.Delimiter`` .
ShouldSkipRecord([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | Returns ``false`` .
ShouldUseConstructorParameters([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Returns ``true`` if ``type`` : 1. does not have a parameterless constructor 2. has a constructor 3. is not a user defined struct 4. is not an interface 5. TypeCode is not an Object.
