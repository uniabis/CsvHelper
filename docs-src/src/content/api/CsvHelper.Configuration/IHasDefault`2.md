# IHasDefault<TClass, TMember> Interface

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Has default capabilities.

```cs
public interface IHasDefault<TClass, TMember> : IBuildableClass<TClass>
```

## Methods
&nbsp; | &nbsp;
- | -
Default(TMember) | The default value that will be used when reading when the CSV field is empty.
Default([String](https://docs.microsoft.com/en-us/dotnet/api/system.string)) | The default value that will be used when reading when the CSV field is empty. This value is not type checked and will use a ``CsvHelper.TypeConversion.ITypeConverter`` to convert the field. This could potentially have runtime errors.
