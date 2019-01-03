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
ObjectResolver([Func<Type, Boolean>, [Func<Type, Object[], Object>, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates an instance of the object resolver using the given can create function and creat function.

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
Resolve([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | Creates an object from the given type using the ``CsvHelper.ObjectResolver.ResolveFunction`` function. If ``CsvHelper.ObjectResolver.CanResolve`` is false, the object will be created using CsvHelper's default object creation. If ``CsvHelper.ObjectResolver.UseFallback`` is false, an exception is thrown.
Resolve&lt;T&gt;([Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | Creates an object from the given type using the ``CsvHelper.ObjectResolver.ResolveFunction`` function. If ``CsvHelper.ObjectResolver.CanResolve`` is false, the object will be created using CsvHelper's default object creation. If ``CsvHelper.ObjectResolver.UseFallback`` is false, an exception is thrown.
