# EnumConverter Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Converts an ``System.Enum`` to and from a ``System.String`` .

```cs
public class EnumConverter : DefaultTypeConverter, ITypeConverter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [DefaultTypeConverter](/api/CsvHelper.TypeConversion/DefaultTypeConverter) -> EnumConverter

## Constructors
&nbsp; | &nbsp;
- | -
EnumConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Creates a new ``CsvHelper.TypeConversion.EnumConverter`` for the given ``System.Enum`` ``System.Type`` .

## Methods
&nbsp; | &nbsp;
- | -
ConvertFromString([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [IReaderRow](/api/CsvHelper/IReaderRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | 
