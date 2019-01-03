# RecordCreator Class

Namespace: [CsvHelper.Expressions](/api/CsvHelper.Expressions)

Base implementation for classes that create records.

```cs
public abstract class RecordCreator : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> RecordCreator

## Constructors
&nbsp; | &nbsp;
- | -
RecordCreator([CsvReader](/api/CsvHelper/CsvReader)) | Initializes a new instance using the given reader.

## Methods
&nbsp; | &nbsp;
- | -
Create&lt;T&gt;() | Create a record of the given type using the current row.
Create([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)) | Create a record of the given type using the current row.
