# FieldValidationException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents a user supplied field validation failure.

```cs
public class FieldValidationException : ValidationException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> [ValidationException](/api/CsvHelper/ValidationException) -> FieldValidationException

## Constructors
&nbsp; | &nbsp;
- | -
FieldValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class.
FieldValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class with a specified error message.
FieldValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.

## Properties
&nbsp; | &nbsp;
- | -
Field | Gets the field that failed validation.
