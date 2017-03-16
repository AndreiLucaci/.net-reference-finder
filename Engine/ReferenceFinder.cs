using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ReferenceFinder.Exceptions;
using ReferenceFinder.Helpers;
using ReferenceFinder.Models;

namespace ReferenceFinder.Engine
{
	public class ReferenceFinder
	{
		private readonly IExceptionHandler _exceptionHandler;
		private readonly IEnumerable<string> _extensions;

		public ReferenceFinder(SearchAssembliesHelper searchAssembliesHelper, IExceptionHandler exceptionHandler)
		{
			_exceptionHandler = exceptionHandler;
			_extensions = searchAssembliesHelper.Extensions;
		}

		public IEnumerable<ReferenceHolder> ProcessFolderName(string folderName)
		{
			var result = new List<ReferenceHolder>();
			try
			{
				var fileNames =
					Directory.GetFiles(folderName, "*.*", SearchOption.AllDirectories)
						.Where(i => _extensions.Contains(Path.GetExtension(i))).ToArray();

				result = new List<ReferenceHolder>();
				foreach (var fileName in fileNames)
				{
					var assembly = Assembly.ReflectionOnlyLoadFrom(fileName);
					var referencedAssemblies = assembly.GetReferencedAssemblies();
					result.Add(new ReferenceHolder
					{
						Dll = fileName, References = referencedAssemblies
					});
				}
			}
			catch (Exception ex)
			{
				_exceptionHandler.Handle(ex);
			}
			return result;
		}
	}
}
