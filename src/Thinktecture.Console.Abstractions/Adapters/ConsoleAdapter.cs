using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.Text;

namespace Thinktecture.Adapters
{
	/// <summary>Represents the standard input, output, and error streams for console applications.</summary>
	public class ConsoleAdapter : IConsole
	{
		private readonly AbstractionDelegateLookup<IConsoleCancelEventArgs, ConsoleCancelEventHandler> _cancelKeyPressLookup;

		/// <summary>
		/// Initializes a new instance of <see cref="ConsoleAdapter"/>.
		/// </summary>
		public ConsoleAdapter()
		{
			_cancelKeyPressLookup = new AbstractionDelegateLookup<IConsoleCancelEventArgs, ConsoleCancelEventHandler>();
		}

		/// <inheritdoc />
		public ConsoleColor BackgroundColor
		{
			get => Console.BackgroundColor;
			set => Console.BackgroundColor = value;
		}

		/// <inheritdoc />
		public int BufferHeight
		{
			get => Console.BufferHeight;
			set => Console.BufferHeight = value;
		}

		/// <inheritdoc />
		public int BufferWidth
		{
			get => Console.BufferWidth;
			set => Console.BufferWidth = value;
		}

		/// <inheritdoc />
		public bool CapsLock => Console.CapsLock;

		/// <inheritdoc />
		public int CursorLeft
		{
			get => Console.CursorLeft;
			set => Console.CursorLeft = value;
		}

		/// <inheritdoc />
		public int CursorSize
		{
			get => Console.CursorSize;
			set => Console.CursorSize = value;
		}

		/// <inheritdoc />
		public int CursorTop
		{
			get => Console.CursorTop;
			set => Console.CursorTop = value;
		}

		/// <inheritdoc />
		public bool CursorVisible
		{
			get => Console.CursorVisible;
			set => Console.CursorVisible = value;
		}

		/// <inheritdoc />
		public ITextWriter Error => Console.Error.ToInterface();

		/// <inheritdoc />
		public ConsoleColor ForegroundColor
		{
			get => Console.ForegroundColor;
			set => Console.ForegroundColor = value;
		}

		/// <inheritdoc />
		public IEncoding InputEncoding
		{
			get => Console.InputEncoding.ToInterface();
			set => Console.InputEncoding = value.ToImplementation();
		}

		/// <inheritdoc />
		public bool IsErrorRedirected => Console.IsErrorRedirected;

		/// <inheritdoc />
		public bool IsInputRedirected => Console.IsInputRedirected;

		/// <inheritdoc />
		public bool IsOutputRedirected => Console.IsOutputRedirected;

		/// <inheritdoc />
		public ITextReader In => Console.In.ToInterface();

		/// <inheritdoc />
		public bool KeyAvailable => Console.KeyAvailable;

		/// <inheritdoc />
		public int LargestWindowWidth => Console.LargestWindowWidth;

		/// <inheritdoc />
		public int LargestWindowHeight => Console.LargestWindowHeight;

		/// <inheritdoc />
		public bool NumberLock => Console.NumberLock;

		/// <inheritdoc />
		public ITextWriter Out => Console.Out.ToInterface();

		/// <inheritdoc />
		public IEncoding OutputEncoding
		{
			get => Console.OutputEncoding.ToInterface();
			set => Console.OutputEncoding = value.ToImplementation();
		}

		/// <inheritdoc />
		public string Title
		{
			get => Console.Title;
			set => Console.Title = value;
		}

		/// <inheritdoc />
		public bool TreatControlCAsInput
		{
			get => Console.TreatControlCAsInput;
			set => Console.TreatControlCAsInput = value;
		}

		/// <inheritdoc />
		public int WindowHeight
		{
			get => Console.WindowHeight;
			set => Console.WindowHeight = value;
		}

		/// <inheritdoc />
		public int WindowWidth
		{
			get => Console.WindowWidth;
			set => Console.WindowWidth = value;
		}

		/// <inheritdoc />
		public int WindowLeft
		{
			get => Console.WindowLeft;
			set => Console.WindowLeft = value;
		}

		/// <inheritdoc />
		public int WindowTop
		{
			get => Console.WindowTop;
			set => Console.WindowTop = value;
		}

		/// <inheritdoc />
		public void Beep()
		{
			Console.Beep();
		}

		/// <inheritdoc />
		public void Beep(int frequency, int duration)
		{
			Console.Beep(frequency, duration);
		}

		/// <inheritdoc />
		public event EventHandler<IConsoleCancelEventArgs> CancelKeyPress
		{
			add => Console.CancelKeyPress += _cancelKeyPressLookup.MapForAttachment(value, abstraction => ((sender, args) => abstraction(sender, args.ToInterface())));
			remove => Console.CancelKeyPress -= _cancelKeyPressLookup.TryMapForDetachment(value);
		}

		/// <inheritdoc />
		public void Clear()
		{
			Console.Clear();
		}

		/// <inheritdoc />
		public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
		{
			Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
		}

		/// <inheritdoc />
		public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
		{
			Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
		}

		/// <inheritdoc />
		public IStream OpenStandardError()
		{
			return Console.OpenStandardError().ToInterface();
		}

#if NET46
		/// <inheritdoc />
		public IStream OpenStandardError(int bufferSize)
		{
			return Console.OpenStandardError(bufferSize).ToInterface();
		}
#endif

		/// <inheritdoc />
		public IStream OpenStandardInput()
		{
			return Console.OpenStandardInput().ToInterface();
		}

#if NET46
		/// <inheritdoc />
		public IStream OpenStandardInput(int bufferSize)
		{
			return Console.OpenStandardInput(bufferSize).ToInterface();
		}
#endif

		/// <inheritdoc />
		public IStream OpenStandardOutput()
		{
			return Console.OpenStandardOutput().ToInterface();
		}

#if NET46
		/// <inheritdoc />
		public IStream OpenStandardOutput(int bufferSize)
		{
			return Console.OpenStandardOutput(bufferSize).ToInterface();
		}
#endif

		/// <inheritdoc />
		public int Read()
		{
			return Console.Read();
		}

		/// <inheritdoc />
		public ConsoleKeyInfo ReadKey()
		{
			return Console.ReadKey();
		}

		/// <inheritdoc />
		public ConsoleKeyInfo ReadKey(bool intercept)
		{
			return Console.ReadKey(intercept);
		}

		/// <inheritdoc />
		public string ReadLine()
		{
			return Console.ReadLine();
		}

		/// <inheritdoc />
		public void ResetColor()
		{
			Console.ResetColor();
		}

		/// <inheritdoc />
		public void SetBufferSize(int width, int height)
		{
			Console.SetBufferSize(width, height);
		}

		/// <inheritdoc />
		public void SetCursorPosition(int left, int top)
		{
			Console.SetCursorPosition(left, top);
		}

		/// <inheritdoc />
		public void SetError(ITextWriter newError)
		{
			Console.SetError(newError.ToImplementation());
		}

		/// <inheritdoc />
		public void SetError(TextWriter newError)
		{
			Console.SetError(newError);
		}

		/// <inheritdoc />
		public void SetIn(ITextReader newIn)
		{
			Console.SetIn(newIn.ToImplementation());
		}

		/// <inheritdoc />
		public void SetIn(TextReader newIn)
		{
			Console.SetIn(newIn);
		}

		/// <inheritdoc />
		public void SetOut(ITextWriter newOut)
		{
			Console.SetOut(newOut.ToImplementation());
		}

		/// <inheritdoc />
		public void SetOut(TextWriter newOut)
		{
			Console.SetOut(newOut);
		}

		/// <inheritdoc />
		public void SetWindowPosition(int left, int top)
		{
			Console.SetWindowPosition(left, top);
		}

		/// <inheritdoc />
		public void SetWindowSize(int width, int height)
		{
			Console.SetWindowSize(width, height);
		}

		/// <inheritdoc />
		public void Write(bool value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(char value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(char[] buffer)
		{
			Console.Write(buffer);
		}

		/// <inheritdoc />
		public void Write(char[] buffer, int index, int count)
		{
			Console.Write(buffer, index, count);
		}

		/// <inheritdoc />
		public void Write(decimal value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(double value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(int value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(long value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(object value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(float value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(string value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(string format, object arg0)
		{
			Console.Write(format, arg0);
		}

		/// <inheritdoc />
		public void Write(string format, object arg0, object arg1)
		{
			Console.Write(format, arg0, arg1);
		}

		/// <inheritdoc />
		public void Write(string format, object arg0, object arg1, object arg2)
		{
			Console.Write(format, arg0, arg1, arg2);
		}

		/// <inheritdoc />
		public void Write(string format, params object[] arg)
		{
			Console.Write(format, arg);
		}

		/// <inheritdoc />
		public void Write(uint value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void Write(ulong value)
		{
			Console.Write(value);
		}

		/// <inheritdoc />
		public void WriteLine()
		{
			Console.WriteLine();
		}

		/// <inheritdoc />
		public void WriteLine(bool value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer)
		{
			Console.WriteLine(buffer);
		}

		/// <inheritdoc />
		public void WriteLine(char[] buffer, int index, int count)
		{
			Console.WriteLine(buffer, index, count);
		}

		/// <inheritdoc />
		public void WriteLine(decimal value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(double value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(int value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(long value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(object value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(float value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(string format, object arg0)
		{
			Console.WriteLine(format, arg0);
		}

		/// <inheritdoc />
		public void WriteLine(string format, object arg0, object arg1)
		{
			Console.WriteLine(format, arg0, arg1);
		}

		/// <inheritdoc />
		public void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			Console.WriteLine(format, arg0, arg1, arg2);
		}

		/// <inheritdoc />
		public void WriteLine(string format, params object[] arg)
		{
			Console.WriteLine(format, arg);
		}

		/// <inheritdoc />
		public void WriteLine(uint value)
		{
			Console.WriteLine(value);
		}

		/// <inheritdoc />
		public void WriteLine(ulong value)
		{
			Console.WriteLine(value);
		}
	}
}
