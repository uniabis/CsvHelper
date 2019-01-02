# ExpressionManager Class

Namespace: [CsvHelper.Expressions](/api/CsvHelper.Expressions)

Manages expression creation.

```cs
public class ExpressionManager : 
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) -> ExpressionManager

## Constructors
&nbsp; | &nbsp;
- | -
ExpressionManager([CsvReader](/api/CsvHelper/CsvReader)) | Initializes a new instance using the given reader.
ExpressionManager([CsvWriter](/api/CsvHelper/CsvWriter)) | Initializes a new instance using the given writer.

## Methods
&nbsp; | &nbsp;
- | -
CreateConstructorArgumentExpressionsForMapping([ClassMap](/api/CsvHelper.Configuration/ClassMap), [List&lt;Expression&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list`1)) | 
CreateGetFieldExpression([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
CreateGetMemberExpression([Expression](https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression), [ClassMap](/api/CsvHelper.Configuration/ClassMap), [MemberMap](/api/CsvHelper.Configuration/MemberMap)) | 
CreateInstanceAndAssignMembers([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [List&lt;MemberAssignment&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list`1)) | 
CreateMemberAssignmentsForMapping([ClassMap](/api/CsvHelper.Configuration/ClassMap), [List&lt;MemberAssignment&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list`1)) | 
