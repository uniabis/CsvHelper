# ByteArrayConverter Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Converts a ``Byte[]`` to and from a ``System.String`` .

```cs
public class ByteArrayConverter : DefaultTypeConverter, ITypeConverter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [DefaultTypeConverter](/api/CsvHelper.TypeConversion/DefaultTypeConverter) -> ByteArrayConverter

## Constructors
&nbsp; | &nbsp;
- | -
ByteArrayConverter([ByteArrayConverterOptions](/api/CsvHelper.TypeConversion/ByteArrayConverterOptions)) | Creates a new ByteArrayConverter using the given ``CsvHelper.TypeConversion.ByteArrayConverterOptions`` .

## Methods
&nbsp; | &nbsp;
- | -
ConvertFromString([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [IReaderRow](/api/CsvHelper/IReaderRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the string to an object.
ConvertToString([Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [IWriterRow](/api/CsvHelper/IWriterRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the object to a string.
