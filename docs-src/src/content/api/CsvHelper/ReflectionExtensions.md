# ReflectionExtensions Class

Namespace: [CsvHelper](/api/CsvHelper)

Extensions to help with reflection.

```cs
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class ReflectionExtensions : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> ReflectionExtensions

## Methods
&nbsp; | &nbsp;
- | -
GetConstructorWithMostParameters([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets the constructor that contains the most parameters.
GetMemberExpression([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo), [Expression](https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression)) | Gets a member expression for the member.
HasConstructor([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets a value indicating if the given type has any constructors.
HasParameterlessConstructor([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets a value indicating if the given type has a parameterless constructor. True if it has a parameterless constructor, otherwise false.
IsAnonymous([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets a value indicating if the given type is anonymous. True for anonymous, otherwise false.
IsUserDefinedStruct([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Gets a value indicating if the type is a user defined struct. True if it is a user defined struct, otherwise false.
MemberType([MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo)) | Gets the type from the member.
