using System;
using JetBrains.Annotations;

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
using System.Collections;
#endif

namespace Thinktecture
{
	/// <summary>Provides information about, and means to manipulate, the current environment and platform. This class cannot be inherited.</summary>
	public interface IEnvironment
	{
		/// <summary>Gets a unique identifier for the current managed thread.</summary>
		/// <returns>An integer that represents a unique identifier for this managed thread.</returns>
		int CurrentManagedThreadId { get; }

		/// <summary>Gets a value that indicates whether the current application domain is being unloaded or the common language runtime (CLR) is shutting down. </summary>
		/// <returns>true if the current application domain is being unloaded or the CLR is shutting down; otherwise, false.</returns>
		bool HasShutdownStarted { get; }

		/// <summary>Gets the newline string defined for this environment.</summary>
		/// <returns>A string containing "\r\n" for non-Unix platforms, or a string containing "\n" for Unix platforms.</returns>
		[NotNull]
		string NewLine { get; }

#if NET45 || NET462 || NETSTANDARD1_5
		/// <summary>Gets the NetBIOS name of this local computer.</summary>
		/// <returns>A string containing the name of this computer.</returns>
		/// <exception cref="InvalidOperationException">The name of this computer cannot be obtained.</exception>
		[NotNull]
		string MachineName { get; }
#endif

		/// <summary>Gets the number of processors on the current machine.</summary>
		/// <returns>The 32-bit signed integer that specifies the number of processors on the current machine. There is no default. If the current machine contains multiple processor groups, this property returns the number of logical processors that are available for use by the common language runtime (CLR).</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="NUMBER_OF_PROCESSORS" />
		/// </PermissionSet>
		int ProcessorCount { get; }

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <summary>Gets current stack trace information.</summary>
		/// <returns>A string containing stack trace information. This value can be <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The requested stack trace information is out of range.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		[NotNull]
		string StackTrace { get; }
#endif

		/// <summary>Gets the number of milliseconds elapsed since the system started.</summary>
		/// <returns>A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started. </returns>
		int TickCount { get; }

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <summary>Replaces the name of each environment variable embedded in the specified string with the string equivalent of the value of the variable, then returns the resulting string.</summary>
		/// <returns>A string with each environment variable replaced by its value.</returns>
		/// <param name="name">A string containing the names of zero or more environment variables. Each environment variable is quoted with the percent sign character (%).</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="name" /> is null.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		string ExpandEnvironmentVariables([NotNull] string name);
#endif

#if NET45 || NET462 || NETSTANDARD1_5
		/// <summary>
		/// Terminates this process and returns an exit code to the operating system.
		/// </summary>
		/// <param name="exitCode">The exit code to return to the operating system. Use 0 (zero) to indicate that the process completed successfully.</param>
		void Exit(int exitCode);
#endif

		/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message in error reporting to Microsoft.</summary>
		/// <param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
		void FailFast([CanBeNull] string message);

		/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message and exception information in error reporting to Microsoft.</summary>
		/// <param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
		/// <param name="exception">An exception that represents the error that caused the termination. This is typically the exception in a catch block.</param>
		void FailFast([CanBeNull] string message, [CanBeNull] Exception exception);

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <summary>Retrieves the value of an environment variable from the current process. </summary>
		/// <returns>The value of the environment variable specified by <paramref name="variable" />, or null if the environment variable is not found.</returns>
		/// <param name="variable">The name of the environment variable.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="variable" /> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[CanBeNull]
		string GetEnvironmentVariable([NotNull] string variable);
#endif

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <summary>Retrieves all environment variable names and their values from the current process.</summary>
		/// <returns>A dictionary that contains all environment variable names and their values; otherwise, an empty dictionary if no environment variables are found.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
		/// <exception cref="T:System.OutOfMemoryException">The buffer is out of memory.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[NotNull]
		IDictionary GetEnvironmentVariables();
#endif

#if NET45 || NET462 || NETSTANDARD1_3 || NETSTANDARD1_5
		/// <summary>Creates, modifies, or deletes an environment variable stored in the current process.</summary>
		/// <param name="variable">The name of an environment variable.</param>
		/// <param name="value">A value to assign to <paramref name="variable" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="variable" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="variable" /> contains a zero-length string, an initial hexadecimal zero character (0x00), or an equal sign ("="). -or-The length of <paramref name="variable" /> or <paramref name="value" /> is greater than or equal to 32,767 characters.-or-An error occurred during the execution of this operation.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		void SetEnvironmentVariable([NotNull] string variable, string value);
#endif

#if NET45 || NET462 || NETSTANDARD1_5
		/// <summary>
		/// Returns a string array containing the command-line arguments for the current process.
		/// </summary>
		/// <returns>An array of string where each element contains a command-line argument. The first element is the executable file name, and the following zero or more elements contain the remaining command-line arguments.</returns>
		[NotNull]
		string[] GetCommandLineArgs();
#endif
	}
}
