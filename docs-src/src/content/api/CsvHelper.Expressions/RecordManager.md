# RecordManager Class

Namespace: [CsvHelper.Expressions](/api/CsvHelper.Expressions)

Manages record manipulation.

```cs
public class RecordManager : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> RecordManager

## Constructors
&nbsp; | &nbsp;
- | -
RecordManager([CsvReader](/api/CsvHelper/CsvReader)) | Initializes a new instance using the given reader.
RecordManager([CsvWriter](/api/CsvHelper/CsvWriter)) | Initializes a new instance using the given writer.

## Methods
&nbsp; | &nbsp;
- | -
Create&lt;T&gt;() | Creates a record of the given type using the current reader row.
Create([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Creates a record of the given type using the current reader row.
Hydrate&lt;T&gt;(T) | Hydrates the given record using the current reader row.
Write&lt;T&gt;(T) | Writes the given record to the current writer row.
