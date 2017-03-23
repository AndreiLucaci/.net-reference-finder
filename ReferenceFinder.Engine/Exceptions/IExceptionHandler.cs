using System;

namespace ReferenceFinder.Engine.Exceptions
{
	public interface IExceptionHandler
	{
		void Handle(Exception exception);
	}
}