using System;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Environment"/>.
	/// </summary>
	public class EnvironmentAdapter : IEnvironment
	{
		/// <inheritdoc />
		public int CurrentManagedThreadId => Environment.CurrentManagedThreadId;

		/// <inheritdoc />
		public bool HasShutdownStarted => Environment.HasShutdownStarted;

		/// <inheritdoc />
		// ReSharper disable once AssignNullToNotNullAttribute
		public string NewLine => Environment.NewLine;

#if NET45 || NET462 || NETSTANDARD1_5
		/// <inheritdoc />
		public string MachineName => Environment.MachineName;
#endif

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
