using System;

namespace Thinktecture.Adapters
{
	public class EnvironmentAdapter : IEnvironment
	{
		/// <inheritdoc />
		public int CurrentManagedThreadId => Environment.CurrentManagedThreadId;

		/// <inheritdoc />
		public bool HasShutdownStarted => Environment.HasShutdownStarted;

		/// <inheritdoc />
		public string NewLine => Environment.NewLine;

		/// <inheritdoc />
		public int ProcessorCount => Environment.ProcessorCount;

		/// <inheritdoc />
		public int TickCount => Environment.TickCount;

		/// <inheritdoc />
		public void FailFast(string message)
		{
			Environment.FailFast(message);
		}

		/// <inheritdoc />
		public void FailFast(string message, Exception exception)
		{
			Environment.FailFast(message, exception);
		}
	}
}