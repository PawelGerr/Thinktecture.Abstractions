using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

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

      /// <inheritdoc />
      public string MachineName => Environment.MachineName;

      /// <inheritdoc />
      public int ProcessorCount => Environment.ProcessorCount;

      /// <inheritdoc />
      public string StackTrace => Environment.StackTrace;

      /// <inheritdoc />
      public int TickCount => Environment.TickCount;

#if NETCOREAPP || NET5_0
      /// <inheritdoc />
      public long TickCount64 => Environment.TickCount64;
#endif

#if NET5_0
      /// <inheritdoc />
      public int ProcessId => Environment.ProcessId;
#endif

      /// <inheritdoc />
      public string ExpandEnvironmentVariables(string name)
      {
         return Environment.ExpandEnvironmentVariables(name);
      }

      /// <inheritdoc />
      public void Exit(int exitCode)
      {
         Environment.Exit(exitCode);
      }

      /// <inheritdoc />
      [DoesNotReturn]
      public void FailFast(string? message)
      {
         Environment.FailFast(message);
      }

      /// <inheritdoc />
      [DoesNotReturn]
      public void FailFast(string? message, Exception? exception)
      {
         Environment.FailFast(message, exception);
      }

      /// <inheritdoc />
      public string? GetEnvironmentVariable(string variable)
      {
         return Environment.GetEnvironmentVariable(variable);
      }

      /// <inheritdoc />
      public string? GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
      {
         return Environment.GetEnvironmentVariable(variable, target);
      }

      /// <inheritdoc />
      public IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target)
      {
         return Environment.GetEnvironmentVariables(target);
      }

      /// <inheritdoc />
      public void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target)
      {
         Environment.SetEnvironmentVariable(variable, value, target);
      }

      /// <inheritdoc />
      public string GetFolderPath(Environment.SpecialFolder folder)
      {
         return Environment.GetFolderPath(folder);
      }

      /// <inheritdoc />
      public string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
      {
         return Environment.GetFolderPath(folder, option);
      }

      /// <inheritdoc />
      public string[] GetLogicalDrives()
      {
         return Environment.GetLogicalDrives();
      }

      /// <inheritdoc />
      public string CommandLine => Environment.CommandLine;

      /// <inheritdoc />
      public string CurrentDirectory
      {
         get => Environment.CurrentDirectory;
         set => Environment.CurrentDirectory = value;
      }

      /// <inheritdoc />
      public bool Is64BitProcess => Environment.Is64BitProcess;

      /// <inheritdoc />
      public bool Is64BitOperatingSystem => Environment.Is64BitOperatingSystem;

      /// <inheritdoc />
      public OperatingSystem OSVersion => Environment.OSVersion;

      /// <inheritdoc />
      public bool UserInteractive => Environment.UserInteractive;

      /// <inheritdoc />
      public Version Version => Environment.Version;

      /// <inheritdoc />
      public long WorkingSet => Environment.WorkingSet;

      /// <inheritdoc />
      public int SystemPageSize => Environment.SystemPageSize;

      /// <inheritdoc />
      public int ExitCode
      {
         get => Environment.ExitCode;
         set => Environment.ExitCode = value;
      }

      /// <inheritdoc />
      public string SystemDirectory => Environment.SystemDirectory;

      /// <inheritdoc />
      public string UserName => Environment.UserName;

      /// <inheritdoc />
      public string UserDomainName => Environment.UserDomainName;

      /// <inheritdoc />
      public IDictionary GetEnvironmentVariables()
      {
         return Environment.GetEnvironmentVariables();
      }

      /// <inheritdoc />
      public void SetEnvironmentVariable(string variable, string value)
      {
         Environment.SetEnvironmentVariable(variable, value);
      }

      /// <inheritdoc />
      public string[] GetCommandLineArgs()
      {
         return Environment.GetCommandLineArgs();
      }
   }
}
