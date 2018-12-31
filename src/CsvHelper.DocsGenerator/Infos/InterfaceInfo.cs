using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class InterfaceInfo : TypeInfo
    {
		public InterfaceInfo(NamespaceInfo namespaceInfo, Type type, XElement xmlDocs) : base(namespaceInfo, type, xmlDocs) { }
    }
}
