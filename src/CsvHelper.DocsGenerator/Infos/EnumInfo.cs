using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public class EnumInfo : TypeInfo
    {
        public EnumInfo(NamespaceInfo namespaceInfo, Type type, XElement xmlDocs) : base(namespaceInfo, type, xmlDocs) { }
    }
}
