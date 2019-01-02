# BadDataException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents errors that occur due to bad data.

```cs
[System.SerializableAttribute]
public class BadDataException : CsvHelperException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> BadDataException

## Constructors
&nbsp; | &nbsp;
- | -
BadDataException([ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.BadDataException`` class.
BadDataException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.BadDataException`` class with a specified error message.
BadDataException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.BadDataException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
