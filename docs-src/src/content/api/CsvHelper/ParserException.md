# ParserException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents errors that occur while parsing a CSV file.

```cs
[System.SerializableAttribute]
public class ParserException : CsvHelperException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> ParserException

## Constructors
&nbsp; | &nbsp;
- | -
ParserException([ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.ParserException`` class.
ParserException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.ParserException`` class with a specified error message.
ParserException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.ParserException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
