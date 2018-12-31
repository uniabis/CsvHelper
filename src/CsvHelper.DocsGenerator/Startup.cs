using CsvHelper.DocsGenerator.Generators;
using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator
{
    public class Startup
    {
		public Startup Configure()
		{
			return this;
		}

		public Startup Run()
		{
			var outputDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Output");
			if (Directory.Exists(outputDirectoryPath))
			{
				Directory.Delete(outputDirectoryPath, true);
			}

			Directory.CreateDirectory(outputDirectoryPath);

			var xmlDocs = XElement.Load("CsvHelper.xml");

			var assemblyInfo = new AssemblyInfo(typeof(CsvHelperException).Assembly, xmlDocs);

			var documentGeneratorFactory = new DocumentGeneratorFactory();

			// Write assembly file.
			var documentGenerator = documentGeneratorFactory.Create(assemblyInfo);
			var content = documentGenerator.Generate();
			var filePath = Path.Combine(outputDirectoryPath, $"{assemblyInfo.Name}.md");
			File.WriteAllText(filePath, content);

			// Write namespace files and directories.
			foreach (var @namespace in assemblyInfo.Namespaces)
			{
				var directoryPath = Path.Combine(outputDirectoryPath, @namespace.Name);
				if (!Directory.Exists(directoryPath))
				{
					Directory.CreateDirectory(directoryPath);
				}

				documentGenerator = documentGeneratorFactory.Create(@namespace);
				content = documentGenerator.Generate();
				filePath = Path.Join(outputDirectoryPath, $"{@namespace.Name}.md");
				File.WriteAllText(filePath, content);
			}

			// Write type files.
			foreach (var @namespace in assemblyInfo.Namespaces)
			{
				var directoryPath = Path.Combine(outputDirectoryPath, @namespace.Name);
				foreach (var typeInfo in @namespace.Types)
				{
					documentGenerator = documentGeneratorFactory.Create(typeInfo);
					content = documentGenerator.Generate();
					filePath = Path.Combine(directoryPath, $"{typeInfo.Name}.md");
					File.WriteAllText(filePath, content);
				}
			}

			return this;
		}
    }
}
