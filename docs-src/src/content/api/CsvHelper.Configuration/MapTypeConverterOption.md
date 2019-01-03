# MapTypeConverterOption Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Sets type converter options on a member map.

```cs
public class MapTypeConverterOption : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> MapTypeConverterOption

## Constructors
&nbsp; | &nbsp;
- | -
MapTypeConverterOption([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Creates a new instance using the given ``CsvHelper.Configuration.MemberMap`` .

## Methods
&nbsp; | &nbsp;
- | -
BooleanValues([Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | The string values used to represent a boolean when converting.
CultureInfo([CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo)) | The ``CsvHelper.Configuration.MapTypeConverterOption.CultureInfo(System.Globalization.CultureInfo)`` used when type converting. This will override the global ``CsvHelper.Configuration.Configuration.CultureInfo`` setting.
DateTimeStyles([DateTimeStyles](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.datetimestyles)) | The ``CsvHelper.Configuration.MapTypeConverterOption.DateTimeStyles(System.Globalization.DateTimeStyles)`` to use when type converting. This is used when doing any ``System.DateTime`` conversions.
Format([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | The string format to be used when type converting.
NullValues([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | The string values used to represent null when converting.
NullValues([Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean), [String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | The string values used to represent null when converting.
NumberStyles([NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.numberstyles)) | The ``CsvHelper.Configuration.MapTypeConverterOption.NumberStyles(System.Globalization.NumberStyles)`` to use when type converting. This is used when doing any number conversions.
