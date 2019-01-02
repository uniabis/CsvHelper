# CsvHelperException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents errors that occur in CsvHelper.

```cs
[System.SerializableAttribute]
public class CsvHelperException : Exception, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> CsvHelperException

## Constructors
&nbsp; | &nbsp;
- | -
CsvHelperException([ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.CsvHelperException`` class.
CsvHelperException([WritingContext](/api/CsvHelper/WritingContext)) | Initializes a new instance of the ``CsvHelper.CsvHelperException`` class.
CsvHelperException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.CsvHelperException`` class with a specified error message.
CsvHelperException([WritingContext](/api/CsvHelper/WritingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.CsvHelperException`` class with a specified error message.
CsvHelperException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.CsvHelperException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
CsvHelperException([WritingContext](/api/CsvHelper/WritingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.CsvHelperException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.

## Properties
&nbsp; | &nbsp;
- | -
ReadingContext | Gets the context used when reading.
WritingContext | Gets the context used when writing.
