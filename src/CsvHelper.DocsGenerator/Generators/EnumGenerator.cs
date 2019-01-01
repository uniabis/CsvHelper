using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator.Generators
{
	public class EnumGenerator : DocumentGenerator
	{
		public EnumGenerator(EnumInfo enumInfo) : base(enumInfo) { }

		protected override void GenerateContent()
		{
			var enumInfo = (EnumInfo)typeInfo;

			// Title
			content.AppendLine($"# {enumInfo.Name} Enum");

			// Namespace
			content.AppendLine();
			content.AppendLine($"Namespace: [{enumInfo.Namespace.Name}](/api/{enumInfo.Namespace.Name})");

			// Summary
			content.AppendLine();
			content.AppendLine(enumInfo.Summary);

			// Definition
			content.AppendLine();
			content.AppendLine("```cs");
			foreach (var attribute in enumInfo.Attributes)
			{
				content.AppendLine($"[{attribute.FullName}]");
			}
			content.AppendLine($"public enum {enumInfo.Name}");
			content.AppendLine("```");
		}
	}
}
