using System.Collections.Generic;
using System.Reflection;

namespace ReferenceFinder.Engine.Models
{
	public class ReferenceHolder
	{
		public string Dll { get; set; }
		public IEnumerable<AssemblyName> References { get; set; }
	}
}