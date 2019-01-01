using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class ClassInfo : TypeInfo
    {
        public ClassInfo(NamespaceInfo namespaceInfo, Type type, XElement xmlDocs) : base(namespaceInfo, type, xmlDocs)
		{
		}
    }
}
