using System;
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.Text;

namespace Thinktecture
{
	/// <summary>Represents the standard input, output, and error streams for console applications. This class cannot be inherited.</summary>
	public interface IConsole
	{
		/// <summary>Gets or sets the background color of the console.</summary>
		/// <returns>A value that specifies the background color of the console; that is, the color that appears behind each character. The default is black.</returns>
		/// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		ConsoleColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the height of the buffer area.</summary>
		/// <returns>The current height, in rows, of the buffer area.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.   -or-   The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue"></see>.   -or-   The value in a set operation is less than <see cref="P:System.Console.WindowTop"></see> + <see cref="P:System.Console.WindowHeight"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		int BufferHeight { get; set; }

		/// <summary>Gets or sets the width of the buffer area.</summary>
		/// <returns>The current width, in columns, of the buffer area.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.   -or-   The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue"></see>.   -or-   The value in a set operation is less than <see cref="P:System.Console.WindowLeft"></see> + <see cref="P:System.Console.WindowWidth"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		int BufferWidth { get; set; }

		/// <summary>Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.</summary>
		/// <returns>true if CAPS LOCK is turned on; false if CAPS LOCK is turned off.</returns>
		bool CapsLock { get; }

		/// <summary>Gets or sets the column position of the cursor within the buffer area.</summary>
		/// <returns>The current position, in columns, of the cursor.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.   -or-   The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferWidth"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		int CursorLeft { get; set; }

		/// <summary>Gets or sets the height of the cursor within a character cell.</summary>
		/// <returns>The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 1 or greater than 100.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		int CursorSize { get; set; }

		/// <summary>Gets or sets the row position of the cursor within the buffer area.</summary>
		/// <returns>The current position, in rows, of the cursor.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.   -or-   The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferHeight"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		int CursorTop { get; set; }

		/// <summary>Gets or sets a value indicating whether the cursor is visible.</summary>
		/// <returns>true if the cursor is visible; otherwise, false.</returns>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		bool CursorVisible { get; set; }

		/// <summary>Gets the standard error output stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter"></see> that represents the standard error output stream.</returns>
		[NotNull]
		ITextWriter Error { get; }

		/// <summary>Gets or sets the foreground color of the console.</summary>
		/// <returns>A <see cref="T:System.ConsoleColor"></see> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is gray.</returns>
		/// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		ConsoleColor ForegroundColor { get; set; }

		/// <summary>Gets or sets the encoding the console uses to read input.</summary>
		/// <returns>The encoding used to read console input.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is null.</exception>
		/// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
		/// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
		[NotNull]
		IEncoding InputEncoding { get; set; }

		/// <summary>Gets a value that indicates whether the error output stream has been redirected from the standard error stream.</summary>
		/// <returns>true if error output is redirected; otherwise, false.</returns>
		bool IsErrorRedirected { get; }

		/// <summary>Gets a value that indicates whether input has been redirected from the standard input stream.</summary>
		/// <returns>true if input is redirected; otherwise, false.</returns>
		bool IsInputRedirected { get; }

		/// <summary>Gets a value that indicates whether output has been redirected from the standard output stream.</summary>
		/// <returns>true if output is redirected; otherwise, false.</returns>
		bool IsOutputRedirected { get; }

		/// <summary>Gets the standard input stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextReader"></see> that represents the standard input stream.</returns>
		[NotNull]
		ITextReader In { get; }

		/// <summary>Gets a value indicating whether a key press is available in the input stream.</summary>
		/// <returns>true if a key press is available; otherwise, false.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.InvalidOperationException">Standard input is redirected to a file instead of the keyboard.</exception>
		bool KeyAvailable { get; }

		/// <summary>Gets the largest possible number of console window columns, based on the current font and screen resolution.</summary>
		/// <returns>The width of the largest possible console window measured in columns.</returns>
		int LargestWindowWidth { get; }

		/// <summary>Gets the largest possible number of console window rows, based on the current font and screen resolution.</summary>
		/// <returns>The height of the largest possible console window measured in rows.</returns>
		int LargestWindowHeight { get; }

		/// <summary>Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.</summary>
		/// <returns>true if NUM LOCK is turned on; false if NUM LOCK is turned off.</returns>
		bool NumberLock { get; }

		/// <summary>Gets the standard output stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter"></see> that represents the standard output stream.</returns>
		[NotNull]
		ITextWriter Out { get; }

		/// <summary>Gets or sets the encoding the console uses to write output.</summary>
		/// <returns>The encoding used to write console output.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is null.</exception>
		/// <exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception>
		/// <exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception>
		[NotNull]
		IEncoding OutputEncoding { get; set; }

		/// <summary>Gets or sets the title to display in the console title bar.</summary>
		/// <returns>The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.</returns>
		/// <exception cref="T:System.InvalidOperationException">In a get operation, the retrieved title is longer than 24500 characters.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the specified title is longer than 24500 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">In a set operation, the specified title is null.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		[NotNull]
		string Title { get; set; }

		/// <summary>Gets or sets a value indicating whether the combination of the <see cref="F:System.ConsoleModifiers.Control"></see> modifier key and <see cref="F:System.ConsoleKey.C"></see> console key (Ctrl+C) is treated as ordinary input or as an interruption that is handled by the operating system.</summary>
		/// <returns>true if Ctrl+C is treated as ordinary input; otherwise, false.</returns>
		/// <exception cref="T:System.IO.IOException">Unable to get or set the input mode of the console input buffer.</exception>
		bool TreatControlCAsInput { get; set; }

		/// <summary>Gets or sets the height of the console window area.</summary>
		/// <returns>The height of the console window measured in rows.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth"></see> property or the value of the <see cref="P:System.Console.WindowHeight"></see> property is less than or equal to 0.   -or-   The value of the <see cref="P:System.Console.WindowHeight"></see> property plus the value of the <see cref="P:System.Console.WindowTop"></see> property is greater than or equal to <see cref="F:System.Int16.MaxValue"></see>.   -or-   The value of the <see cref="P:System.Console.WindowWidth"></see> property or the value of the <see cref="P:System.Console.WindowHeight"></see> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		int WindowHeight { get; set; }

		/// <summary>Gets or sets the width of the console window.</summary>
		/// <returns>The width of the console window measured in columns.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth"></see> property or the value of the <see cref="P:System.Console.WindowHeight"></see> property is less than or equal to 0.   -or-   The value of the <see cref="P:System.Console.WindowHeight"></see> property plus the value of the <see cref="P:System.Console.WindowTop"></see> property is greater than or equal to <see cref="F:System.Int16.MaxValue"></see>.   -or-   The value of the <see cref="P:System.Console.WindowWidth"></see> property or the value of the <see cref="P:System.Console.WindowHeight"></see> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		int WindowWidth { get; set; }

		/// <summary>Gets or sets the leftmost position of the console window area relative to the screen buffer.</summary>
		/// <returns>The leftmost console window position measured in columns.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.   -or-   As a result of the assignment, <see cref="P:System.Console.WindowLeft"></see> plus <see cref="P:System.Console.WindowWidth"></see> would exceed <see cref="P:System.Console.BufferWidth"></see>.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		int WindowLeft { get; set; }

		/// <summary>Gets or sets the top position of the console window area relative to the screen buffer.</summary>
		/// <returns>The uppermost console window position measured in rows.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.   -or-   As a result of the assignment, <see cref="P:System.Console.WindowTop"></see> plus <see cref="P:System.Console.WindowHeight"></see> would exceed <see cref="P:System.Console.BufferHeight"></see>.</exception>
		/// <exception cref="T:System.IO.IOException">Error reading or writing information.</exception>
		int WindowTop { get; set; }

		/// <summary>Plays the sound of a beep through the console speaker.</summary>
		/// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to a user interface.</exception>
		void Beep();

		/// <summary>Plays the sound of a beep of a specified frequency and duration through the console speaker.</summary>
		/// <param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz.</param>
		/// <param name="duration">The duration of the beep measured in milliseconds.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="frequency">frequency</paramref> is less than 37 or more than 32767 hertz.   -or-  <paramref name="duration">duration</paramref> is less than or equal to zero.</exception>
		/// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to the console.</exception>
		void Beep(int frequency, int duration);

		/// <summary>Occurs when the <see cref="F:System.ConsoleModifiers.Control"></see> modifier key (Ctrl) and either the <see cref="F:System.ConsoleKey.C"></see> console key (C) or the Break key are pressed simultaneously (Ctrl+C or Ctrl+Break).</summary>
		/// <returns></returns>
		event EventHandler<IConsoleCancelEventArgs> CancelKeyPress;

		/// <summary>Clears the console buffer and corresponding console window of display information.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Clear();

		/// <summary>Copies a specified source area of the screen buffer to a specified destination area.</summary>
		/// <param name="sourceLeft">The leftmost column of the source area.</param>
		/// <param name="sourceTop">The topmost row of the source area.</param>
		/// <param name="sourceWidth">The number of columns in the source area.</param>
		/// <param name="sourceHeight">The number of rows in the source area.</param>
		/// <param name="targetLeft">The leftmost column of the destination area.</param>
		/// <param name="targetTop">The topmost row of the destination area.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.   -or-  <paramref name="sourceLeft">sourceLeft</paramref> or <paramref name="targetLeft">targetLeft</paramref> is greater than or equal to <see cref="P:System.Console.BufferWidth"></see>.   -or-  <paramref name="sourceTop">sourceTop</paramref> or <paramref name="targetTop">targetTop</paramref> is greater than or equal to <see cref="P:System.Console.BufferHeight"></see>.   -or-  <paramref name="sourceTop">sourceTop</paramref> + <paramref name="sourceHeight">sourceHeight</paramref> is greater than or equal to <see cref="P:System.Console.BufferHeight"></see>.   -or-  <paramref name="sourceLeft">sourceLeft</paramref> + <paramref name="sourceWidth">sourceWidth</paramref> is greater than or equal to <see cref="P:System.Console.BufferWidth"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop);

		/// <summary>Copies a specified source area of the screen buffer to a specified destination area.</summary>
		/// <param name="sourceLeft">The leftmost column of the source area.</param>
		/// <param name="sourceTop">The topmost row of the source area.</param>
		/// <param name="sourceWidth">The number of columns in the source area.</param>
		/// <param name="sourceHeight">The number of rows in the source area.</param>
		/// <param name="targetLeft">The leftmost column of the destination area.</param>
		/// <param name="targetTop">The topmost row of the destination area.</param>
		/// <param name="sourceChar">The character used to fill the source area.</param>
		/// <param name="sourceForeColor">The foreground color used to fill the source area.</param>
		/// <param name="sourceBackColor">The background color used to fill the source area.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.   -or-  <paramref name="sourceLeft">sourceLeft</paramref> or <paramref name="targetLeft">targetLeft</paramref> is greater than or equal to <see cref="P:System.Console.BufferWidth"></see>.   -or-  <paramref name="sourceTop">sourceTop</paramref> or <paramref name="targetTop">targetTop</paramref> is greater than or equal to <see cref="P:System.Console.BufferHeight"></see>.   -or-  <paramref name="sourceTop">sourceTop</paramref> + <paramref name="sourceHeight">sourceHeight</paramref> is greater than or equal to <see cref="P:System.Console.BufferHeight"></see>.   -or-  <paramref name="sourceLeft">sourceLeft</paramref> + <paramref name="sourceWidth">sourceWidth</paramref> is greater than or equal to <see cref="P:System.Console.BufferWidth"></see>.</exception>
		/// <exception cref="T:System.ArgumentException">One or both of the color parameters is not a member of the <see cref="T:System.ConsoleColor"></see> enumeration.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor);

		/// <summary>Acquires the standard error stream.</summary>
		/// <returns>The standard error stream.</returns>
		[NotNull]
		IStream OpenStandardError();

#if NET46 || NETSTANDARD2_0
		/// <summary>Acquires the standard error stream, which is set to a specified buffer size.</summary>
		/// <param name="bufferSize">The internal stream buffer size.</param>
		/// <returns>The standard error stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize">bufferSize</paramref> is less than or equal to zero.</exception>
		[NotNull]
		IStream OpenStandardError(int bufferSize);
#endif

		/// <summary>Acquires the standard input stream.</summary>
		/// <returns>The standard input stream.</returns>
		[NotNull]
		IStream OpenStandardInput();

#if NET46 || NETSTANDARD2_0
		/// <summary>Acquires the standard input stream, which is set to a specified buffer size.</summary>
		/// <param name="bufferSize">The internal stream buffer size.</param>
		/// <returns>The standard input stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize">bufferSize</paramref> is less than or equal to zero.</exception>
		[NotNull]
		IStream OpenStandardInput(int bufferSize);
#endif

		/// <summary>Acquires the standard output stream.</summary>
		/// <returns>The standard output stream.</returns>
		[NotNull]
		IStream OpenStandardOutput();

#if NET46 || NETSTANDARD2_0
		/// <summary>Acquires the standard output stream, which is set to a specified buffer size.</summary>
		/// <param name="bufferSize">The internal stream buffer size.</param>
		/// <returns>The standard output stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize">bufferSize</paramref> is less than or equal to zero.</exception>
		[NotNull]
		IStream OpenStandardOutput(int bufferSize);
#endif

		/// <summary>Reads the next character from the standard input stream.</summary>
		/// <returns>The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		int Read();

		/// <summary>Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.</summary>
		/// <returns>An object that describes the <see cref="T:System.ConsoleKey"></see> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo"></see> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers"></see> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In"></see> property is redirected from some stream other than the console.</exception>
		ConsoleKeyInfo ReadKey();

		/// <summary>Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.</summary>
		/// <param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false.</param>
		/// <returns>An object that describes the <see cref="T:System.ConsoleKey"></see> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo"></see> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers"></see> values, whether one or more Shift, Alt, or Ctrl modifier keys was pressed simultaneously with the console key.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In"></see> property is redirected from some stream other than the console.</exception>
		ConsoleKeyInfo ReadKey(bool intercept);

		/// <summary>Reads the next line of characters from the standard input stream.</summary>
		/// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line of characters is greater than <see cref="F:System.Int32.MaxValue"></see>.</exception>
		[CanBeNull]
		string ReadLine();

		/// <summary>Sets the foreground and background console colors to their defaults.</summary>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void ResetColor();

		/// <summary>Sets the height and width of the screen buffer area to the specified values.</summary>
		/// <param name="width">The width of the buffer area measured in columns.</param>
		/// <param name="height">The height of the buffer area measured in rows.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="height">height</paramref> or <paramref name="width">width</paramref> is less than or equal to zero.   -or-  <paramref name="height">height</paramref> or <paramref name="width">width</paramref> is greater than or equal to <see cref="F:System.Int16.MaxValue"></see>.   -or-  <paramref name="width">width</paramref> is less than <see cref="P:System.Console.WindowLeft"></see> + <see cref="P:System.Console.WindowWidth"></see>.   -or-  <paramref name="height">height</paramref> is less than <see cref="P:System.Console.WindowTop"></see> + <see cref="P:System.Console.WindowHeight"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void SetBufferSize(int width, int height);

		/// <summary>Sets the position of the cursor.</summary>
		/// <param name="left">The column position of the cursor. Columns are numbered from left to right starting at 0.</param>
		/// <param name="top">The row position of the cursor. Rows are numbered from top to bottom starting at 0.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="left">left</paramref> or <paramref name="top">top</paramref> is less than zero.   -or-  <paramref name="left">left</paramref> is greater than or equal to <see cref="P:System.Console.BufferWidth"></see>.   -or-  <paramref name="top">top</paramref> is greater than or equal to <see cref="P:System.Console.BufferHeight"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void SetCursorPosition(int left, int top);

		/// <summary>Sets the <see cref="P:System.Console.Error"></see> property to the specified <see cref="T:System.IO.TextWriter"></see> object.</summary>
		/// <param name="newError">A stream that is the new standard error output.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="newError">newError</paramref> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		void SetError([NotNull] TextWriter newError);

		/// <summary>Sets the <see cref="P:System.Console.Error"></see> property to the specified <see cref="T:System.IO.TextWriter"></see> object.</summary>
		/// <param name="newError">A stream that is the new standard error output.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="newError">newError</paramref> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		void SetError([NotNull] ITextWriter newError);

		/// <summary>Sets the <see cref="P:System.Console.In"></see> property to the specified <see cref="T:System.IO.TextReader"></see> object.</summary>
		/// <param name="newIn">A stream that is the new standard input.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="newIn">newIn</paramref> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		void SetIn([NotNull] TextReader newIn);

		/// <summary>Sets the <see cref="P:System.Console.In"></see> property to the specified <see cref="T:System.IO.TextReader"></see> object.</summary>
		/// <param name="newIn">A stream that is the new standard input.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="newIn">newIn</paramref> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		void SetIn([NotNull] ITextReader newIn);

		/// <summary>Sets the <see cref="P:System.Console.Out"></see> property to the specified <see cref="T:System.IO.TextWriter"></see> object.</summary>
		/// <param name="newOut">A stream that is the new standard output.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="newOut">newOut</paramref> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		void SetOut([NotNull] TextWriter newOut);

		/// <summary>Sets the <see cref="P:System.Console.Out"></see> property to the specified <see cref="T:System.IO.TextWriter"></see> object.</summary>
		/// <param name="newOut">A stream that is the new standard output.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="newOut">newOut</paramref> is null.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
		void SetOut([NotNull] ITextWriter newOut);

		/// <summary>Sets the position of the console window relative to the screen buffer.</summary>
		/// <param name="left">The column position of the upper left  corner of the console window.</param>
		/// <param name="top">The row position of the upper left corner of the console window.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="left">left</paramref> or <paramref name="top">top</paramref> is less than zero.   -or-  <paramref name="left">left</paramref> + <see cref="P:System.Console.WindowWidth"></see> is greater than <see cref="P:System.Console.BufferWidth"></see>.   -or-  <paramref name="top">top</paramref> + <see cref="P:System.Console.WindowHeight"></see> is greater than <see cref="P:System.Console.BufferHeight"></see>.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void SetWindowPosition(int left, int top);

		/// <summary>Sets the height and width of the console window to the specified values.</summary>
		/// <param name="width">The width of the console window measured in columns.</param>
		/// <param name="height">The height of the console window measured in rows.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="width">width</paramref> or <paramref name="height">height</paramref> is less than or equal to zero.   -or-  <paramref name="width">width</paramref> plus <see cref="P:System.Console.WindowLeft"></see> or <paramref name="height">height</paramref> plus <see cref="P:System.Console.WindowTop"></see> is greater than or equal to <see cref="F:System.Int16.MaxValue"></see>.   -or-  <paramref name="width">width</paramref> or <paramref name="height">height</paramref> is greater than the largest possible window width or height for the current screen resolution and console font.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void SetWindowSize(int width, int height);

		/// <summary>Writes the text representation of the specified Boolean value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(bool value);

		/// <summary>Writes the specified Unicode character value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(char value);

		/// <summary>Writes the specified array of Unicode characters to the standard output stream.</summary>
		/// <param name="buffer">A Unicode character array.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write([CanBeNull] char[] buffer);

		/// <summary>Writes the specified subarray of Unicode characters to the standard output stream.</summary>
		/// <param name="buffer">An array of Unicode characters.</param>
		/// <param name="index">The starting position in buffer.</param>
		/// <param name="count">The number of characters to write.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index">index</paramref> or <paramref name="count">count</paramref> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException"><paramref name="index">index</paramref> plus <paramref name="count">count</paramref> specify a position that is not within <paramref name="buffer">buffer</paramref>.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write([NotNull] char[] buffer, int index, int count);

		/// <summary>Writes the text representation of the specified <see cref="T:System.Decimal"></see> value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(decimal value);

		/// <summary>Writes the text representation of the specified double-precision floating-point value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(double value);

		/// <summary>Writes the text representation of the specified 32-bit signed integer value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(int value);

		/// <summary>Writes the text representation of the specified 64-bit signed integer value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(long value);

		/// <summary>Writes the text representation of the specified object to the standard output stream.</summary>
		/// <param name="value">The value to write, or null.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write([CanBeNull] object value);

		/// <summary>Writes the text representation of the specified single-precision floating-point value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(float value);

		/// <summary>Writes the specified string value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write([CanBeNull] string value);

		/// <summary>Writes the text representation of the specified object to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">An object to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void Write([NotNull] string format, object arg0);

		/// <summary>Writes the text representation of the specified objects to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using format.</param>
		/// <param name="arg1">The second object to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void Write([NotNull] string format, object arg0, object arg1);

		/// <summary>Writes the text representation of the specified objects to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using format.</param>
		/// <param name="arg1">The second object to write using format.</param>
		/// <param name="arg2">The third object to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void Write([NotNull] string format, object arg0, object arg1, object arg2);

		/// <summary>Writes the text representation of the specified array of objects to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg">An array of objects to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> or <paramref name="arg">arg</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void Write([NotNull] string format, [NotNull] params object[] arg);

		/// <summary>Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(uint value);

		/// <summary>Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void Write(ulong value);

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine();

		/// <summary>Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(bool value);

		/// <summary>Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(char value);

		/// <summary>Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="buffer">A Unicode character array.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine([CanBeNull] char[] buffer);

		/// <summary>Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="buffer">An array of Unicode characters.</param>
		/// <param name="index">The starting position in buffer.</param>
		/// <param name="count">The number of characters to write.</param>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index">index</paramref> or <paramref name="count">count</paramref> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException"><paramref name="index">index</paramref> plus <paramref name="count">count</paramref> specify a position that is not within <paramref name="buffer">buffer</paramref>.</exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine([NotNull] char[] buffer, int index, int count);

		/// <summary>Writes the text representation of the specified <see cref="T:System.Decimal"></see> value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(decimal value);

		/// <summary>Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(double value);

		/// <summary>Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(int value);

		/// <summary>Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(long value);

		/// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine([CanBeNull] object value);

		/// <summary>Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(float value);

		/// <summary>Writes the specified string value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine([CanBeNull] string value);

		/// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">An object to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void WriteLine([NotNull] string format, object arg0);

		/// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using format.</param>
		/// <param name="arg1">The second object to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void WriteLine([NotNull] string format, object arg0, object arg1);

		/// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to write using format.</param>
		/// <param name="arg1">The second object to write using format.</param>
		/// <param name="arg2">The third object to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void WriteLine([NotNull] string format, object arg0, object arg1, object arg2);

		/// <summary>Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg">An array of objects to write using format.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="format">format</paramref> or <paramref name="arg">arg</paramref> is null.</exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format">format</paramref> is invalid.</exception>
		void WriteLine([NotNull] string format, [NotNull] params object[] arg);

		/// <summary>Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(uint value);

		/// <summary>Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write.</param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception>
		void WriteLine(ulong value);
	}
}
