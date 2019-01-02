# MemberNameCollection Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

A collection that holds member names.

```cs
[System.Reflection.DefaultMemberAttribute]
public class MemberNameCollection : IEnumerable<String>, IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> MemberNameCollection

## Properties
&nbsp; | &nbsp;
- | -
Count | Gets the count.
this[[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets the name at the given index. If a prefix is set, it will be prepended to the name.
Names | Gets the raw list of names without the prefix being prepended.
Prefix | Gets the prefix to use for each name.

## Methods
&nbsp; | &nbsp;
- | -
Add([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | 
AddRange([IEnumerable&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable`1)) | 
Clear() | 
GetEnumerator() | 
