# IFieldReader Interface

Namespace: [CsvHelper](/api/CsvHelper)

Defines methods used to read a field in a CSV file.

```cs
public interface IFieldReader : IDisposable
```

## Properties
&nbsp; | &nbsp;
- | -
Context | Gets the reading context.
IsBufferEmpty | Gets a value indicating if the buffer is empty. True if the buffer is empty, otherwise false.

## Methods
&nbsp; | &nbsp;
- | -
AppendField() | 
FillBuffer() | 
FillBufferAsync() | 
GetChar() | 
GetField() | 
SetBufferPosition([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetFieldEnd([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetFieldStart([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetRawRecordEnd([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetRawRecordStart([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
