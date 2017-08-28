using System;
using JetBrains.Annotations;

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

		/// <summary>Gets the number of processors on the current machine.</summary>
		/// <returns>The 32-bit signed integer that specifies the number of processors on the current machine. There is no default. If the current machine contains multiple processor groups, this property returns the number of logical processors that are available for use by the common language runtime (CLR).</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="NUMBER_OF_PROCESSORS" />
		/// </PermissionSet>
		int ProcessorCount { get; }

		/// <summary>Gets the number of milliseconds elapsed since the system started.</summary>
		/// <returns>A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started. </returns>
		int TickCount { get; }

		/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message in error reporting to Microsoft.</summary>
		/// <param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
		void FailFast([CanBeNull] string message);

		/// <summary>Immediately terminates a process after writing a message to the Windows Application event log, and then includes the message and exception information in error reporting to Microsoft.</summary>
		/// <param name="message">A message that explains why the process was terminated, or null if no explanation is provided.</param>
		/// <param name="exception">An exception that represents the error that caused the termination. This is typically the exception in a catch block.</param>
		void FailFast([CanBeNull] string message, [CanBeNull] Exception exception);
	}
}
