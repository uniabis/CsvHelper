# ReaderException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents errors that occur while reading a CSV file.

```cs
[System.SerializableAttribute]
public class ReaderException : CsvHelperException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> ReaderException

## Constructors
&nbsp; | &nbsp;
- | -
ReaderException([ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.ReaderException`` class.
ReaderException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.ReaderException`` class with a specified error message.
ReaderException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.ReaderException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
