using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator.Generators
{
	public class NamespaceGenerator : DocumentGenerator
	{
		public NamespaceGenerator(NamespaceInfo namespaceInfo) : base(namespaceInfo) { }

		protected override void GenerateContent()
		{
			content.AppendLine($"# {namespaceInfo.Name} Namespace");

			if (namespaceInfo.Classes.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Classes");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var typeInfo in namespaceInfo.Classes)
				{
					content.AppendLine($"[{typeInfo.Name}](/api/{namespaceInfo.Name}/{typeInfo.Name}) | {typeInfo.Summary}");
				}
			}

			if (namespaceInfo.Interfaces.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Interfaces");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var typeInfo in namespaceInfo.Interfaces)
				{
					content.AppendLine($"[{typeInfo.Name}](/api/{namespaceInfo.Name}/{typeInfo.Name}) | {typeInfo.Summary}");
				}
			}

			if (namespaceInfo.Enums.Count > 0)
			{
				content.AppendLine();
				content.AppendLine("## Enums");
				content.AppendLine("&nbsp; | &nbsp;");
				content.AppendLine("- | -");
				foreach (var typeInfo in namespaceInfo.Enums)
				{
					content.AppendLine($"[{typeInfo.Name}](/api/{namespaceInfo.Name}/{typeInfo.Name}) | {typeInfo.Summary}");
				}
			}
		}
	}
}
