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
		}
	}
}
