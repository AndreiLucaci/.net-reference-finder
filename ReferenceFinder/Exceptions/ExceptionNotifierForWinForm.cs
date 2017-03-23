using System;
using System.Windows.Forms;
using ReferenceFinder.Engine.Exceptions;

namespace ReferenceFinder.Win.Exceptions
{
	public class ExceptionNotifierForWinForm : IExceptionHandler
	{
		public void Handle(Exception exception)
		{
			var message = exception.Message;

			if (exception.InnerException != null)
			{
				var ex = exception;
				var stackTraceLevel = 0;
				do
				{
					message += $"Exception Stack Trace Level {stackTraceLevel++}:\r\n{ex.Message}";
				} while ((ex = ex.InnerException) != null);
			}

			MessageBox.Show(message);
		}
	}
}
