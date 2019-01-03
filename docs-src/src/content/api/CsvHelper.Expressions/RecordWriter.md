# RecordWriter Class

Namespace: [CsvHelper.Expressions](/api/CsvHelper.Expressions)

Base implementation for classes that write records.

```cs
public abstract class RecordWriter : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> RecordWriter

## Constructors
&nbsp; | &nbsp;
- | -
RecordWriter([CsvWriter](/api/CsvHelper/CsvWriter)) | Initializes a new instance using the given writer.

## Methods
&nbsp; | &nbsp;
- | -
Write&lt;T&gt;(T) | Writes the record to the current row.
