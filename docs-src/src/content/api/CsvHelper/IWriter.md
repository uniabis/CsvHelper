# IWriter Interface

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to write to a CSV file.

```cs
public interface IWriter : IWriterRow, IDisposable
```

## Methods
&nbsp; | &nbsp;
- | -
Flush() | 
FlushAsync() | 
NextRecord() | 
NextRecordAsync() | 
WriteRecords([IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)) | 
WriteRecords([IEnumerable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable`1)) | 
