# IEnumerableGenericConverter Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Converts an ``System.Collections.Generic.IEnumerable`1`` to and from a ``System.String`` .

```cs
public class IEnumerableGenericConverter : IEnumerableConverter, ITypeConverter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [DefaultTypeConverter](/api/CsvHelper.TypeConversion/DefaultTypeConverter) -> [IEnumerableConverter](/api/CsvHelper.TypeConversion/IEnumerableConverter) -> IEnumerableGenericConverter

## Methods
&nbsp; | &nbsp;
- | -
ConvertFromString([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [IReaderRow](/api/CsvHelper/IReaderRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the string to an object.
