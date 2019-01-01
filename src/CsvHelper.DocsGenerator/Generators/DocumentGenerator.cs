using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvHelper.DocsGenerator.Generators
{
	public abstract class DocumentGenerator
    {
		protected readonly LinkGenerator linkGenerator = new LinkGenerator();
		protected readonly AssemblyInfo assemblyInfo;
		protected readonly NamespaceInfo namespaceInfo;
		protected readonly TypeInfo typeInfo;
		protected readonly StringBuilder content = new StringBuilder();

		public DocumentGenerator(AssemblyInfo assemblyInfo)
		{
			this.assemblyInfo = assemblyInfo ?? throw new ArgumentNullException(nameof(assemblyInfo));
		}

		public DocumentGenerator(NamespaceInfo namespaceInfo)
		{
			this.namespaceInfo = namespaceInfo;
		}

		public DocumentGenerator(TypeInfo typeInfo)
		{
			this.typeInfo = typeInfo ?? throw new ArgumentNullException(nameof(typeInfo));
		}

		public string Generate()
		{
			content.Clear();

			GenerateContent();

			return content.ToString();
		}

		protected abstract void GenerateContent();

		protected void GenerateInheritance()
		{
			if (typeInfo.Type.BaseType != null)
			{
				var inheritanceStack = new Stack<string>();
				inheritanceStack.Push(typeInfo.Name);
				var currentType = typeInfo.Type.BaseType;
				do
				{
					inheritanceStack.Push(linkGenerator.GenerateLink(currentType));
					currentType = currentType.BaseType;
				}
				while (currentType != null);

				content.AppendLine();
				content.AppendLine($"Inheritance {string.Join(" -> ", inheritanceStack)}");
			}
		}

		private string GetName()
		{
			if (assemblyInfo != null)
			{
				return assemblyInfo.Name;
			}

			return typeInfo.Name;
		}
    }
}
