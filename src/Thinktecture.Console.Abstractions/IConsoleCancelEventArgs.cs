using System;
using System.IO;

namespace Thinktecture
{
	/// <summary>Provides data for the <see cref="E:System.Console.CancelKeyPress"></see> event. This class cannot be inherited.</summary>
	public interface IConsoleCancelEventArgs : IEventArgs, IAbstraction<ConsoleCancelEventArgs>
	{
		/// <summary>Gets or sets a value that indicates whether simultaneously pressing the <see cref="F:System.ConsoleModifiers.Control"></see> modifier key and the <see cref="F:System.ConsoleKey.C"></see> console key (Ctrl+C) or the Ctrl+Break keys terminates the current process. The default is false, which terminates the current process.</summary>
		/// <returns>true if the current process should resume when the event handler concludes; false if the current process should terminate. The default value is false; the current process terminates when the event handler returns. If true, the current process continues.</returns>
		bool Cancel { get; set; }

		/// <summary>Gets the combination of modifier and console keys that interrupted the current process.</summary>
		/// <returns>One of the enumeration values that specifies the key combination that interrupted the current process. There is no default value.</returns>
		ConsoleSpecialKey SpecialKey { get; }
	}
}
