using CsvHelper.DocsGenerator.Infos;
using System;
using System.Text;

namespace CsvHelper.DocsGenerator.Generators
{
	public abstract class DocumentGenerator
    {
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

		protected string GetTypeLink(Type type, bool useFullName = false)
		{
			var name = useFullName ? type.FullName : type.Name;

			if (type.Namespace.StartsWith("CsvHelper"))
			{
				return $"[{name}](/api/{type.Namespace}/{type.Name})";
			}

			var fullName = type.FullName ?? $"{type.Namespace}.{type.Name}";

			return $"[{name}](https://docs.microsoft.com/en-us/dotnet/api/{fullName.ToLower()})";
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
