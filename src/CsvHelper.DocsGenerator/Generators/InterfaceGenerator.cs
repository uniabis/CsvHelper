using CsvHelper.DocsGenerator.Infos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator.Generators
{
	public class InterfaceGenerator : DocumentGenerator
	{
		public InterfaceGenerator(InterfaceInfo interfaceInfo) : base(interfaceInfo) { }

		protected override void GenerateContent()
		{
		}
	}
}
