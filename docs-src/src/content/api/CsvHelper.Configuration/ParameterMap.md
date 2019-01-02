# ParameterMap Class

Namespace: [CsvHelper.Configuration](/api/CsvHelper.Configuration)

Mapping for a constructor parameter. This may contain value type data, a constructor type map, or a reference map, depending on the type of the parameter.

```cs
[System.Diagnostics.DebuggerDisplayAttribute]
public class ParameterMap : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> ParameterMap

## Constructors
&nbsp; | &nbsp;
- | -
ParameterMap([ParameterInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.parameterinfo)) | Creates an instance of ``CsvHelper.Configuration.ParameterMap`` using the given information.

## Properties
&nbsp; | &nbsp;
- | -
ConstructorTypeMap | Gets or sets the map for a constructor type.
Data | Gets the parameter map data.
ReferenceMap | Gets or sets the map for a reference type.
