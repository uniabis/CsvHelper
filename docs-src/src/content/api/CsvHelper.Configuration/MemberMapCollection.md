# MemberMapCollection Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

A collection that holds ``CsvHelper.Configuration.MemberMap`` 's.

```cs
[System.Diagnostics.DebuggerDisplayAttribute]
[System.Reflection.DefaultMemberAttribute]
public class MemberMapCollection : IList<MemberMap>, ICollection<MemberMap>, IEnumerable<MemberMap>, IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> MemberMapCollection

## Constructors
&nbsp; | &nbsp;
- | -
MemberMapCollection() | Initializes a new instance of the ``CsvHelper.Configuration.MemberMapCollection`` class.
MemberMapCollection([IComparer&lt;MemberMap&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer`1)) | 

## Properties
&nbsp; | &nbsp;
- | -
Count | Gets the number of elements contained in the ``System.Collections.Generic.ICollection`1`` .
IsReadOnly | Gets a value indicating whether the ``System.Collections.Generic.ICollection`1`` is read-only.
this[[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets or sets the element at the specified index.

## Methods
&nbsp; | &nbsp;
- | -
Add([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
AddMembers([ClassMap](/api/CsvHelper.Configuration/ClassMap)) | 
AddRange([ICollection&lt;MemberMap&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection`1)) | 
Clear() | 
Contains([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
CopyTo([MemberMap[]](/api/CsvHelper.Configuration/MemberMap[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
Find([Expression&lt;Func&lt;T,Object&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression`1)) | 
Find([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo)) | 
GetEnumerator() | 
IndexOf([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
Insert([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
Remove([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
RemoveAt([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
