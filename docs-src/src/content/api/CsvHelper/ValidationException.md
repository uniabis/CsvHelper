# ValidationException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents a user supplied validation failure.

```cs
[System.SerializableAttribute]
public abstract class ValidationException : CsvHelperException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> ValidationException

## Constructors
&nbsp; | &nbsp;
- | -
ValidationException([ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class.
ValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class with a specified error message.
ValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
