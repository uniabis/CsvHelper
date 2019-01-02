# MemberMap&lt;TClass,TMember&gt; Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Mapping info for a member to a CSV field.

```cs
[System.Diagnostics.DebuggerDisplayAttribute]
public class MemberMap<TClass,TMember> : MemberMap
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [MemberMap](/api/CsvHelper.Configuration/MemberMap) -> MemberMap&lt;TClass,TMember&gt;

## Constructors
&nbsp; | &nbsp;
- | -
MemberMap&lt;TClass,TMember&gt;([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo)) | Creates a new ``CsvHelper.Configuration.MemberMap`` instance using the specified member.

## Methods
&nbsp; | &nbsp;
- | -
Constant([TMember](/api/CsvHelper.Configuration/TMember)) | 
ConvertUsing([Func&lt;IReaderRow,TMember&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.func`2)) | 
ConvertUsing([Func&lt;TClass,String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.func`2)) | 
Default([TMember](/api/CsvHelper.Configuration/TMember)) | 
Default([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
Ignore() | 
Ignore([Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 
Index([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
Name([String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string[])) | 
NameIndex([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
Optional() | 
TypeConverter([ITypeConverter](/api/CsvHelper.TypeConversion/ITypeConverter)) | 
TypeConverter() | 
Validate([Func&lt;String,Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.func`2)) | 
