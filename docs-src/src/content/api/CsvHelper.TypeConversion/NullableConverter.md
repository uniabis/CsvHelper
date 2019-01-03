# NullableConverter Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Converts a ``System.Nullable`1`` to and from a ``System.String`` .

```cs
public class NullableConverter : DefaultTypeConverter, ITypeConverter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [DefaultTypeConverter](/api/CsvHelper.TypeConversion/DefaultTypeConverter) -> NullableConverter

## Constructors
&nbsp; | &nbsp;
- | -
NullableConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [TypeConverterCache](/api/CsvHelper.TypeConversion/TypeConverterCache)) | Creates a new ``CsvHelper.TypeConversion.NullableConverter`` for the given ``System.Nullable`1`` ``System.Type`` .

## Properties
&nbsp; | &nbsp;
- | -
NullableType | Gets the type of the nullable.
UnderlyingType | Gets the underlying type of the nullable.
UnderlyingTypeConverter | Gets the type converter for the underlying type.

## Methods
&nbsp; | &nbsp;
- | -
ConvertFromString([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [IReaderRow](/api/CsvHelper/IReaderRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the string to an object.
ConvertToString([Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [IWriterRow](/api/CsvHelper/IWriterRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the object to a string.
