using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator.Generators
{
    public class TypeGenerator : DocumentGenerator
    {
		public TypeGenerator(TypeInfo typeInfo) : base(typeInfo) { }

		protected override void GenerateContent()
		{
			var fileType = string.Empty;
			if (typeInfo.Type.IsEnum)
			{
				fileType = "Enum";
			}
			else if (typeInfo.Type.IsInterface)
			{
				fileType = "Interface";
			}
			else if (typeInfo.Type.IsClass)
			{
				fileType = "Class";
			}

			// Title
			content.AppendLine($"# {htmlFormatter.Format(typeInfo.Type)} {fileType}");

			// Namespace
			content.AppendLine();
			content.AppendLine($"Namespace: [{typeInfo.Type.Namespace}](/api/{typeInfo.Type.Namespace})");

			// Summary
			content.AppendLine();
			content.AppendLine(typeInfo.Summary);

			// Definition
			content.AppendLine();
			content.AppendLine("```cs");
			foreach (var attribute in typeInfo.Attributes)
			{
				content.AppendLine($"[{attribute.Namespace}.{htmlFormatter.Format(attribute)}]");
			}

			var inheritance = new List<string>();
			if (typeInfo.Type.BaseType != null && typeInfo.Type.BaseType != typeof(object))
			{
				inheritance.Add(htmlFormatter.Format(typeInfo.Type.BaseType));
			}

			inheritance.AddRange(typeInfo.Interfaces.Select(i => htmlFormatter.Format(i)));
			var inheritanceText = typeInfo.Type.IsEnum ? string.Empty : $": {string.Join(", ", inheritance)}";
			var typeModifier = string.Empty;
			if (typeInfo.Type.IsAbstract && typeInfo.Type.IsSealed && !typeInfo.Type.IsInterface)
			{
				typeModifier = "static ";
			}
			else if (typeInfo.Type.IsAbstract && !typeInfo.Type.IsSealed && !typeInfo.Type.IsInterface)
			{
				typeModifier = "abstract ";
			}

			content.AppendLine($"public {typeModifier}{fileType.ToLower()} {htmlFormatter.Format(typeInfo.Type)} {inheritanceText}");
			content.AppendLine("```");

			// Inheritance
			if (typeInfo.Type.BaseType != null)
			{
				var inheritanceStack = new Stack<string>();
				inheritanceStack.Push(typeInfo.Type.GetDisplayName());
				var currentType = typeInfo.Type.BaseType;
				do
				{
					inheritanceStack.Push(htmlFormatter.Format(currentType, generateLinks: true));
					currentType = currentType.BaseType;
				}
				while (currentType != null);

				content.AppendLine();
				content.AppendLine($"Inheritance {string.Join(" -> ", inheritanceStack)}");
			}

			// Constructors
			if (typeInfo.Constructors.Count > 0)
			{
				content.AppendLine("");
				content.AppendLine("## Constructors");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var constructorInfo in typeInfo.Constructors)
				{
					content.AppendLine($"{htmlFormatter.Format(constructorInfo.Constructor)} | {constructorInfo.Summary}");
				}
			}

			// Fields
			if (typeInfo.Fields.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Fields");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var field in typeInfo.Fields)
				{
					content.AppendLine($"{field.Name} | {field.Summary}");
				}
			}

			// Properties
			if (typeInfo.Properties.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Properties");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var property in typeInfo.Properties)
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
			if (typeInfo.Methods.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Methods");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var method in typeInfo.Methods)
				{
					content.AppendLine($"{htmlFormatter.Format(method.Method)} | {method.Summary}");
				}
			}
		}
	}
}
