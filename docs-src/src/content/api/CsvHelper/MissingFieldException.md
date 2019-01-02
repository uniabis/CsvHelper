# MissingFieldException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents an error caused because a field is missing in the header while reading a CSV file.

```cs
[System.SerializableAttribute]
public class MissingFieldException : ReaderException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> [ReaderException](/api/CsvHelper/ReaderException) -> MissingFieldException

## Constructors
&nbsp; | &nbsp;
- | -
MissingFieldException([ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.MissingFieldException`` class.
MissingFieldException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.MissingFieldException`` class with a specified error message.
MissingFieldException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.MissingFieldException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
