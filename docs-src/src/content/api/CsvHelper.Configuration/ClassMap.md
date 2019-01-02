# ClassMap Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Maps class members to CSV fields.

```cs
public abstract class ClassMap : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> ClassMap

## Properties
&nbsp; | &nbsp;
- | -
ClassType | The type of the class this map is for.
MemberMaps | The class member mappings.
ParameterMaps | The class constructor parameter mappings.
ReferenceMaps | The class member reference mappings.

## Methods
&nbsp; | &nbsp;
- | -
AutoMap() | 
AutoMap([Configuration](/api/CsvHelper.Configuration/Configuration)) | 
GetMaxIndex() | 
Map([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 
Map() | 
References([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo), [Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | 
ReIndex([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
