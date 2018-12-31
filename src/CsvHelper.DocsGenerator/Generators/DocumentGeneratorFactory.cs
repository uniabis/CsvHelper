using CsvHelper.DocsGenerator.Infos;
using System;

namespace CsvHelper.DocsGenerator.Generators
{
    public class DocumentGeneratorFactory
    {    
		public DocumentGenerator Create(AssemblyInfo assemblyInfo)
		{
			return new AssemblyGenerator(assemblyInfo);
		}

		public DocumentGenerator Create(NamespaceInfo namespaceInfo)
		{
			return new NamespaceGenerator(namespaceInfo);
		}

		public DocumentGenerator Create(TypeInfo typeInfo)
		{
			if (typeInfo is ClassInfo)
			{
				return new ClassGenerator((ClassInfo)typeInfo);
			}

			if (typeInfo is InterfaceInfo)
			{
				return new InterfaceGenerator((InterfaceInfo)typeInfo);
			}

			if (typeInfo is EnumInfo)
			{
				return new EnumGenerator((EnumInfo)typeInfo);
			}

			throw new InvalidOperationException($"Type '{typeInfo.Name}' has no generator.");
		}
    }
}
