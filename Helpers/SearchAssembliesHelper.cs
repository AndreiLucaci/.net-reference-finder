using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using ReferenceFinder.Exceptions;

namespace ReferenceFinder.Helpers
{
	public class SearchAssembliesHelper
	{
		private readonly IExceptionHandler _exceptionHandler;
		public IEnumerable<string> Extensions;
		private readonly IEnumerable<string> _defaultExtensions = new[] {".dll"};

		public SearchAssembliesHelper(IExceptionHandler exceptionHandler)
		{
			_exceptionHandler = exceptionHandler;
			SetExtensions();
		}

		private void SetExtensions()
		{
			try
			{
				Extensions = ConfigurationManager.AppSettings["search-extensions"].Split(',')
					.Where(i => !string.IsNullOrEmpty(i) && Regex.IsMatch(i, @".+\..+"));
			}
			catch (Exception ex)
			{
				// handle exception
				_exceptionHandler.Handle(ex);
			}

			if (!Extensions.Any())
			{
				Extensions = _defaultExtensions;
			}
		}
	}
}