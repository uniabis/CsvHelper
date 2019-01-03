using CsvHelper.DocsGenerator.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CsvHelper.DocsGenerator.Infos
{
    public abstract class Info
    {
		protected readonly XmlDocFormatter xmlDocFormatter = new XmlDocFormatter();

		public string Name { get; protected set; }

		public string FullName { get; protected set; }

		public string Summary { get; protected set; }

		protected string ParseSummary(string memberName, XElement xmlDocs)
		{
			var members = xmlDocs.Descendants("member");
			var member = members?.SingleOrDefault(m => m.Attribute("name")?.Value == memberName);
			var summary = member?.Element("summary");
			if (summary != null)
			{
				var summaryText = new List<string>();
				foreach (var node in summary.Nodes())
				{
					string text;
					if (node.NodeType == XmlNodeType.Element)
					{
						var el = (XElement)node;
						switch (el.Name.ToString())
						{
							case "paramref":
								text = el.Attribute("name").Value;
								break;
							case "see":
								text = el.Attribute("cref").Value.Substring(2);
								break;
							case "c":
								text = el.Value;
								break;
							default:
								throw new InvalidOperationException($"Unhandled element '{el.Name}'.");
						}

						text = $"``{text.Trim()}``";
					}
					else if (node.NodeType == XmlNodeType.Text)
					{
						text = node.ToString();
					}
					else
					{
						throw new InvalidOperationException($"Unhandled node type '{node.NodeType}'.");
					}

					text = Regex.Replace(text, @"\s{2,}", " ").Trim();

					summaryText.Add(text);
				}

				return string.Join(" ", summaryText);
			}

			return null;
		}
	}
}
