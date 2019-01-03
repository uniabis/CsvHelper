# IHasConvertUsing<TClass, TMember> Interface

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Has convert using capabilities.

```cs
public interface IHasConvertUsing<TClass, TMember> : IBuildableClass<TClass>
```

## Methods
&nbsp; | &nbsp;
- | -
ConvertUsing([Func<IReaderRow, TMember>) | Specifies an expression to be used to convert data in the row to the member.
ConvertUsing([Func<TClass, String>) | Specifies an expression to be used to convert the object to a field.
