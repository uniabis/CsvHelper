# IHasMap<TClass> Interface

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Has mapping capabilities.

```cs
public interface IHasMap<TClass> : IBuildableClass<TClass>
```

## Methods
&nbsp; | &nbsp;
- | -
Map&lt;TMember&gt;([Expression<Func<TClass, TMember>>, [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Maps a member to a CSV field.
