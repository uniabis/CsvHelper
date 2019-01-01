using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class FieldInfo : Info
    {
        public FieldInfo(System.Reflection.FieldInfo fieldInfo, XElement xmlDocs)
		{
			Name = fieldInfo.Name;

			FullName = $"{fieldInfo.DeclaringType.FullName}.{Name}";

			Summary = ParseSummary($"F:{FullName}", xmlDocs);
		}
    }
}
