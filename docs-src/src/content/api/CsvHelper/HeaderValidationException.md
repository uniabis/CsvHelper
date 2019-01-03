# HeaderValidationException Class

Namespace: [CsvHelper](/api/CsvHelper)

Represents a header validation failure.

```cs
public class HeaderValidationException : ValidationException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> [ValidationException](/api/CsvHelper/ValidationException) -> HeaderValidationException

## Constructors
&nbsp; | &nbsp;
- | -
HeaderValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Nullable<Int32>) | Initializes a new instance of the ``CsvHelper.ValidationException`` class.
HeaderValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Nullable<Int32>, [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class with a specified error message.
HeaderValidationException([ReadingContext](/api/CsvHelper/ReadingContext), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[]), [Nullable<Int32>, [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.ValidationException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.

## Properties
&nbsp; | &nbsp;
- | -
HeaderNameIndex | Gets the header name index that is mapped to a CSV field that couldn't be found. The index is used when a CSV header has multiple header names with the same value.
HeaderNames | Gets the header names that are mapped to a CSV field that couldn't be found.
