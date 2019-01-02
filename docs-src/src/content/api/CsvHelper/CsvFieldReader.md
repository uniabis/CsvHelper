# CsvFieldReader Class

Namespace: [CsvHelper](/api/CsvHelper)

Reads fields from a ``System.IO.TextReader`` .

```cs
public class CsvFieldReader : IFieldReader, IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> CsvFieldReader

## Constructors
&nbsp; | &nbsp;
- | -
CsvFieldReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration)) | Creates a new ``CsvHelper.CsvFieldReader`` using the given ``System.IO.TextReader`` and ``CsvHelper.Configuration.Configuration`` .
CsvFieldReader([TextReader](https://docs.microsoft.com/en-us/dotnet/api/system.io.textreader), [Configuration](/api/CsvHelper.Configuration/Configuration), [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)) | Creates a new ``CsvHelper.CsvFieldReader`` using the given ``System.IO.TextReader`` , ``CsvHelper.Configuration.Configuration`` and leaveOpen flag.

## Properties
&nbsp; | &nbsp;
- | -
Context | Gets the reading context.
IsBufferEmpty | Gets a value indicating if the buffer is empty. True if the buffer is empty, otherwise false.

## Methods
&nbsp; | &nbsp;
- | -
AppendField() | 
Dispose() | 
FillBuffer() | 
FillBufferAsync() | 
GetChar() | 
GetField() | 
SetBufferPosition([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetFieldEnd([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetFieldStart([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetRawRecordEnd([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
SetRawRecordStart([Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)) | 
