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
MemberMapCollection([IComparer<MemberMap>) | Initializes a new instance of the ``CsvHelper.Configuration.MemberMapCollection`` class.

## Properties
&nbsp; | &nbsp;
- | -
Count | Gets the number of elements contained in the ``System.Collections.Generic.ICollection`1`` .
IsReadOnly | Gets a value indicating whether the ``System.Collections.Generic.ICollection`1`` is read-only.
this[[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)] | Gets or sets the element at the specified index.

## Methods
&nbsp; | &nbsp;
- | -
Add([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Adds an item to the ``System.Collections.Generic.ICollection`1`` .
AddMembers([ClassMap](/api/CsvHelper.Configuration/ClassMap)) | Adds the members from the mapping. This will recursively traverse the mapping tree and add all members for reference maps.
AddRange([ICollection<MemberMap>) | Adds a range of items to the ``System.Collections.Generic.ICollection`1`` .
Clear() | Removes all items from the ``System.Collections.Generic.ICollection`1`` .
Contains([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Determines whether the ``System.Collections.Generic.ICollection`1`` contains a specific value.
CopyTo([MemberMap[]](/api/CsvHelper.Configuration/MemberMap[]), [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Copies the elements of the ``System.Collections.Generic.ICollection`1`` to an ``System.Array`` , starting at a particular ``System.Array`` index.
Find&lt;T&gt;([Expression<Func<T, Object>>) | Finds the ``CsvHelper.Configuration.MemberMap`` using the given member expression.
Find([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo)) | Finds the ``CsvHelper.Configuration.MemberMap`` using the given member.
GetEnumerator() | Returns an enumerator that iterates through the collection.
IndexOf([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Determines the index of a specific item in the ``System.Collections.Generic.IList`1`` .
Insert([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32), [MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Inserts an item to the ``System.Collections.Generic.IList`1`` at the specified index.
Remove([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Removes the first occurrence of a specific object from the ``System.Collections.Generic.ICollection`1`` .
RemoveAt([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | Removes the ``System.Collections.Generic.IList`1`` item at the specified index.
