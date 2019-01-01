using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.DocsGenerator
{
    public class LinkGenerator
    {
        public string GenerateLink(Type type, bool useFullName = false)
		{
			var name = useFullName ? type.FullName : type.Name;

			if (type.Namespace.StartsWith("CsvHelper"))
			{
				return $"[{name}](/api/{type.Namespace}/{type.Name})";
			}

			var fullName = type.FullName ?? $"{type.Namespace}.{type.Name}";

			return $"[{name}](https://docs.microsoft.com/en-us/dotnet/api/{fullName.ToLower()})";
		}
	}
}
