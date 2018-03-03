using System;
using System.Collections;

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
		public string NewLine => Environment.NewLine;

#if NET45 || NET462 || NETSTANDARD1_5
		/// <inheritdoc />
		public string MachineName => Environment.MachineName;
#endif

		/// <inheritdoc />
		public int ProcessorCount => Environment.ProcessorCount;

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <inheritdoc />
		public string StackTrace => Environment.StackTrace;
#endif

		/// <inheritdoc />
		public int TickCount => Environment.TickCount;

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <inheritdoc />
		public string ExpandEnvironmentVariables(string name)
		{
			return Environment.ExpandEnvironmentVariables(name);
		}
#endif

#if NET45 || NET462 || NETSTANDARD1_5
		/// <inheritdoc />
		public void Exit(int exitCode)
		{
			Environment.Exit(exitCode);
		}
#endif

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

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <inheritdoc />
		public string GetEnvironmentVariable(string variable)
		{
			return Environment.GetEnvironmentVariable(variable);
		}
#endif

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <inheritdoc />
		public IDictionary GetEnvironmentVariables()
		{
			return Environment.GetEnvironmentVariables();
		}
#endif

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <inheritdoc />
		public void SetEnvironmentVariable(string variable, string value)
		{
			Environment.SetEnvironmentVariable(variable, value);
		}
#endif

#if NET45 || NET462 || NETSTANDARD1_5
		/// <inheritdoc />
		public string[] GetCommandLineArgs()
		{
			return Environment.GetCommandLineArgs();
		}
#endif
	}
}
