# ObjectResolver Class

Namespace: [CsvHelper](/api/CsvHelper)

Creates objects from a given type.

```cs
public class ObjectResolver : IObjectResolver
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> ObjectResolver

## Constructors
&nbsp; | &nbsp;
- | -
ObjectResolver() | Creates an instance of the object resolver using default values.
ObjectResolver([Func&lt;Type,Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.func`2), [Func&lt;Type,Object[],Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.func`3), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | 

## Properties
&nbsp; | &nbsp;
- | -
CanResolve | A function that returns a value indicating if the resolver is able to resolve the given type. True if the type can be resolved, otherwise false.
Current | Gets or sets the current resolver.
ResolveFunction | The function that creates an object from a given type.
UseFallback | A value indicating if the resolver's ``CsvHelper.ObjectResolver.CanResolve`` returns false that an object will still be created using CsvHelper's object creation. True to fallback, otherwise false. Default value is true.

## Methods
&nbsp; | &nbsp;
- | -
Resolve([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | 
Resolve([Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | 
