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
CreateConstructorArgumentExpressionsForMapping([ClassMap](/api/CsvHelper.Configuration/ClassMap), [List<Expression>) | Creates the constructor arguments used to create a type.
CreateGetFieldExpression([MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Creates an expression the represents getting the field for the given member and converting it to the member's type.
CreateGetMemberExpression([Expression](https://docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression), [ClassMap](/api/CsvHelper.Configuration/ClassMap), [MemberMap](/api/CsvHelper.Configuration/MemberMap)) | Creates a member expression for the given member on the record. This will recursively traverse the mapping to find the member and create a safe member accessor for each level as it goes.
CreateInstanceAndAssignMembers([Type](https://docs.microsoft.com/en-us/dotnet/api/system.type), [List<MemberAssignment>) | Creates an instance of the given type using ``CsvHelper.ReflectionHelper.CreateInstance(System.Type,System.Object[])`` (in turn using the ObjectResolver), then assigns the given member assignments to that instance.
CreateMemberAssignmentsForMapping([ClassMap](/api/CsvHelper.Configuration/ClassMap), [List<MemberAssignment>) | Creates the member assignments for the given ``CsvHelper.Configuration.ClassMap`` .
