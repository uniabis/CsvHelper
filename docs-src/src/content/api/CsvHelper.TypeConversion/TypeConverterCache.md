# TypeConverterCache Class

Namespace: [CsvHelper.TypeConversion](/api/CsvHelper.TypeConversion)

Caches ``CsvHelper.TypeConversion.ITypeConverter`` s for a given type.

```cs
public class TypeConverterCache : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> TypeConverterCache

## Constructors
&nbsp; | &nbsp;
- | -
TypeConverterCache() | Initializes the ``CsvHelper.TypeConversion.TypeConverterCache`` class.

## Methods
&nbsp; | &nbsp;
- | -
AddConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
AddConverter([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
GetConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
GetConverter([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo)) | 
GetConverter() | 
RemoveConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | 
RemoveConverter() | 
