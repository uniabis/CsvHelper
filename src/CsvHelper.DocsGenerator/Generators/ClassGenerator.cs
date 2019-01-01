using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator.Generators
{
    public class ClassGenerator : DocumentGenerator
    {
        public ClassGenerator(ClassInfo classInfo) : base(classInfo) { }

		protected override void GenerateContent()
		{
			var classInfo = (ClassInfo)typeInfo;

			// Title
			content.AppendLine($"# {classInfo.Name} Class");

			// Namespace
			content.AppendLine();
			content.AppendLine($"Namespace: [{classInfo.Namespace.Name}](/api/{classInfo.Namespace.Name})");

			// Summary
			content.AppendLine();
			content.AppendLine(classInfo.Summary);

			// Definition
			content.AppendLine();
			content.AppendLine("```cs");
			foreach (var attribute in classInfo.Attributes)
			{
				content.AppendLine($"[{attribute.FullName}]");
			}
			var inheritance = new List<string> { classInfo.Type.BaseType.Name };
			inheritance.AddRange(classInfo.Interfaces.Select(i => i.Name));
			var abstractText = classInfo.Type.IsAbstract ? "abstract " : string.Empty;
			content.AppendLine($"public {abstractText}class {classInfo.Name} : {string.Join(", ", inheritance)}");
			content.AppendLine("```");

			// Inheritance
			if (classInfo.Type.BaseType != null)
			{
				var inheritanceStack = new Stack<string>();
				inheritanceStack.Push(classInfo.Name);
				var currentType = classInfo.Type.BaseType;
				do
				{
					inheritanceStack.Push(linkGenerator.GenerateLink(currentType));
					currentType = currentType.BaseType;
				}
				while (currentType != null);

				content.AppendLine();
				content.AppendLine($"Inheritance {string.Join(" -> ", inheritanceStack)}");
			}

			// Constructors
			content.AppendLine("");
			content.AppendLine("## Constructors");
			content.AppendLine("&nbsp; | &nbsp;");
			content.AppendLine("- | -");
			foreach (var constructorInfo in classInfo.Constructors)
			{
				var parameters = constructorInfo.Parameters.Select(p => linkGenerator.GenerateLink(p.ParameterType));
				content.AppendLine($"{classInfo.Name}({string.Join(", ", parameters)}) | {constructorInfo.Summary}");
			}

			// Fields
			if (classInfo.Fields.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Fields");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var field in classInfo.Fields)
				{
					content.AppendLine($"{field.Name} | {field.Summary}");
				}
			}

			// Properties
			if (classInfo.Properties.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Properties");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var property in classInfo.Properties)
				{
					if (property.IndexParameters.Count > 0)
					{
						var parameters = string.Join(", ", property.IndexParameters.Select(ip => linkGenerator.GenerateLink(ip.ParameterType)));
						content.AppendLine($"this[{parameters}] | {property.Summary}");
					}
					else
					{
						content.AppendLine($"{property.Name} | {property.Summary}");
					}
				}
			}

			// Methods
			if (classInfo.Methods.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Methods");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var method in classInfo.Methods)
				{
					var parameters = string.Join(", ", method.Parameters.Select(p => linkGenerator.GenerateLink(p.ParameterType)));
					content.AppendLine($"{method.Name}({parameters}) | {method.Summary}");
				}
			}
		}
	}
}
