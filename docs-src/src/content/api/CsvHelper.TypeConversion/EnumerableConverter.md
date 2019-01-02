# EnumerableConverter Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Throws an exception when used. This is here so that it's apparent that there is no support for ``System.Collections.IEnumerable`` type coversion. A custom converter will need to be created to have a field convert to and from an IEnumerable.

```cs
public class EnumerableConverter : DefaultTypeConverter, ITypeConverter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [DefaultTypeConverter](/api/CsvHelper.TypeConversion/DefaultTypeConverter) -> EnumerableConverter

## Methods
&nbsp; | &nbsp;
- | -
ConvertFromString([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [IReaderRow](/api/CsvHelper/IReaderRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | 
ConvertToString([Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [IWriterRow](/api/CsvHelper/IWriterRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | 
