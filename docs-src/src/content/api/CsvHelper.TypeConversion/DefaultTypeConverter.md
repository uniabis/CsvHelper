# DefaultTypeConverter Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Converts an ``System.Object`` to and from a ``System.String`` .

```cs
public class DefaultTypeConverter : ITypeConverter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> DefaultTypeConverter

## Methods
&nbsp; | &nbsp;
- | -
ConvertFromString([String](https://docs.microsoft.com/en-us/dotnet/api/system.string), [IReaderRow](/api/CsvHelper/IReaderRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the string to an object.
ConvertToString([Object](https://docs.microsoft.com/en-us/dotnet/api/system.object), [IWriterRow](/api/CsvHelper/IWriterRow), [MemberMapData](/api/CsvHelper.Configuration/MemberMapData)) | Converts the object to a string.
