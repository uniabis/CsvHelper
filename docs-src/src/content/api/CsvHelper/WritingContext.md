# WritingContext Class

Namespace: [CsvHelper](/api/CsvHelper)

CSV writing state.

```cs
public class WritingContext : IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> WritingContext

## Constructors
&nbsp; | &nbsp;
- | -
WritingContext([TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter), [Configuration](/api/CsvHelper.Configuration/Configuration), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Initializes a new instance.

## Properties
&nbsp; | &nbsp;
- | -
HasHeaderBeenWritten | Gets a value indicating if the header has been written.
HasRecordBeenWritten | Gets a value indicating if a record has been written.
LeaveOpen | Gets a value indicating if the ``CsvHelper.WritingContext.Writer`` should be left open when disposing.
Record | Get the current record;
ReusableMemberMapData | Gets or sets the reusable member map data.
Row | Gets the current row.
SerializerConfiguration | Gets the serializer configuration.
TypeActions | Gets the type actions.
TypeConverterOptionsCache | Gets the type converter options.
Writer | Gets the ``System.IO.TextWriter`` .
WriterConfiguration | Gets the writer configuration.

## Methods
&nbsp; | &nbsp;
- | -
ClearCache([Caches](/api/CsvHelper/Caches)) | 
Dispose() | 
