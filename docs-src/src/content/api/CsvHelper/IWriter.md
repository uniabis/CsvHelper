# IWriter Interface

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to write to a CSV file.

```cs
public interface IWriter : IWriterRow, IDisposable
```

## Methods
&nbsp; | &nbsp;
- | -
Flush() | Serializes the row to the ``System.IO.TextWriter`` .
FlushAsync() | Serializes the row to the ``System.IO.TextWriter`` .
NextRecord() | Ends writing of the current record and starts a new record. This automatically flushes the writer.
NextRecordAsync() | Ends writing of the current record and starts a new record. This automatically flushes the writer.
WriteRecords([IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)) | Writes the list of records to the CSV file.
WriteRecords&lt;T&gt;([IEnumerable<T>) | Writes the list of records to the CSV file.
