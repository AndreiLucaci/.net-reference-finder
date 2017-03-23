using System;

namespace ReferenceFinder.Exceptions
{
	public interface IExceptionHandler
	{
		void Handle(Exception exception);
	}
}