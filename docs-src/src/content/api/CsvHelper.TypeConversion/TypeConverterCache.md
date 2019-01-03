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
AddConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Adds the ``CsvHelper.TypeConversion.ITypeConverter`` for the given ``System.Type`` .
AddConverter&lt;T&gt;([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | Adds the ``CsvHelper.TypeConversion.ITypeConverter`` for the given ``System.Type`` .
GetConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets the converter for the given ``System.Type`` .
GetConverter([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo)) | Gets the converter for the given member. If an attribute is found on the member, that will be used, otherwise the cache will be used.
GetConverter&lt;T&gt;() | Gets the converter for the given ``System.Type`` .
RemoveConverter([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Removes the ``CsvHelper.TypeConversion.ITypeConverter`` for the given ``System.Type`` .
RemoveConverter&lt;T&gt;() | Removes the ``CsvHelper.TypeConversion.ITypeConverter`` for the given ``System.Type`` .
