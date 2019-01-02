# TypeConverterException Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Represents errors that occur while reading a CSV file.

```cs
[System.SerializableAttribute]
public class TypeConverterException : CsvHelperException, ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) -> [CsvHelperException](/api/CsvHelper/CsvHelperException) -> TypeConverterException

## Constructors
&nbsp; | &nbsp;
- | -
TypeConverterException([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ReadingContext](/api/CsvHelper/ReadingContext)) | Initializes a new instance of the ``CsvHelper.TypeConversion.TypeConverterException`` class.
TypeConverterException([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData), [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [WritingContext](/api/CsvHelper/WritingContext)) | Initializes a new instance of the ``CsvHelper.TypeConversion.TypeConverterException`` class.
TypeConverterException([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.TypeConversion.TypeConverterException`` class with a specified error message.
TypeConverterException([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData), [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [WritingContext](/api/CsvHelper/WritingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | Initializes a new instance of the ``CsvHelper.TypeConversion.TypeConverterException`` class with a specified error message.
TypeConverterException([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [ReadingContext](/api/CsvHelper/ReadingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.TypeConversion.TypeConverterException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.
TypeConverterException([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData), [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [WritingContext](/api/CsvHelper/WritingContext), [String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)) | Initializes a new instance of the ``CsvHelper.TypeConversion.TypeConverterException`` class with a specified error message and a reference to the inner exception that is the cause of this exception.

## Properties
&nbsp; | &nbsp;
- | -
MemberMapData | The member map data used in ConvertFromString and ConvertToString.
Text | The text used in ConvertFromString.
TypeConverter | The type converter.
Value | The value used in ConvertToString.
