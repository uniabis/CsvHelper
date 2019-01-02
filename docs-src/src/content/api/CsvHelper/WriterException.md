# WriterException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents errors that occur while writing a CSV file.

```cs
[System.SerializableAttribute]
public class WriterException : CsvHelperException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> WriterException

## Constructors
&nbsp; | &nbsp;
- | -
WriterException([WritingContext](/api/CsvHelper/WritingContext)) | Initializes a new instance of the ``CsvHelper.WriterException`` class.
WriterException([WritingContext](/api/CsvHelper/WritingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.WriterException`` class with a specified error message.
WriterException([WritingContext](/api/CsvHelper/WritingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.WriterException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
