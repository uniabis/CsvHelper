using System;
using System.Collections.Generic;
using System.Text;

namespace CsvHelper
{
	internal static class CsvParserExtentions
	{
		public static string EmptyToNull( this string v, bool a )
		{
			return (!a || (v != string.Empty)) ? v : null;
		}
	}
}
