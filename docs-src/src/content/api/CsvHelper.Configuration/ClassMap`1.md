# ClassMap<TClass> Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Maps class members to CSV fields.

```cs
public abstract class ClassMap<TClass> : ClassMap
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> [ClassMap](/api/CsvHelper.Configuration/ClassMap) -> ClassMap&lt;TClass&gt;

## Constructors
&nbsp; | &nbsp;
- | -
ClassMap`1() | Creates an instance of ``CsvHelper.Configuration.ClassMap`1`` .

## Methods
&nbsp; | &nbsp;
- | -
Map&lt;TMember&gt;([Expression<Func<TClass, TMember>>, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Maps a member to a CSV field.
References&lt;TClassMap&gt;([Expression<Func<TClass, Object>>, [Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object[])) | Meant for internal use only. Maps a member to another class map. When this is used, accessing a property through sub-property mapping later won't work. You can only use one or the other. When using this, ConvertUsing will also not work.
