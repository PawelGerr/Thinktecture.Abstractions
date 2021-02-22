using System;
using System.IO;
using System.Runtime.Versioning;
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

#pragma warning disable CA1416
      /// <inheritdoc />
      public int BufferHeight
      {
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         get => Console.BufferHeight;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.BufferHeight = value;
      }

      /// <inheritdoc />
      public int BufferWidth
      {
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         get => Console.BufferWidth;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.BufferWidth = value;
      }
#pragma warning restore CA1416

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public bool CapsLock => Console.CapsLock;

      /// <inheritdoc />
      public int CursorLeft
      {
         get => Console.CursorLeft;
         set => Console.CursorLeft = value;
      }

#pragma warning disable CA1416
      /// <inheritdoc />
      public int CursorSize
      {
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         get => Console.CursorSize;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.CursorSize = value;
      }
#pragma warning restore CA1416

      /// <inheritdoc />
      public int CursorTop
      {
         get => Console.CursorTop;
         set => Console.CursorTop = value;
      }

#pragma warning disable CA1416
      /// <inheritdoc />
      public bool CursorVisible
      {
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         get => Console.CursorVisible;
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         set => Console.CursorVisible = value;
      }
#pragma warning restore CA1416

      /// <inheritdoc />
      // ReSharper disable once AssignNullToNotNullAttribute
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
         // ReSharper disable once AssignNullToNotNullAttribute
         get => Console.InputEncoding.ToInterface();
         // ReSharper disable once AssignNullToNotNullAttribute
         set => Console.InputEncoding = value.ToImplementation();
      }

      /// <inheritdoc />
      public bool IsErrorRedirected => Console.IsErrorRedirected;

      /// <inheritdoc />
      public bool IsInputRedirected => Console.IsInputRedirected;

      /// <inheritdoc />
      public bool IsOutputRedirected => Console.IsOutputRedirected;

      /// <inheritdoc />
      // ReSharper disable once AssignNullToNotNullAttribute
      public ITextReader In => Console.In.ToInterface();

      /// <inheritdoc />
      public bool KeyAvailable => Console.KeyAvailable;

      /// <inheritdoc />
      public int LargestWindowWidth => Console.LargestWindowWidth;

      /// <inheritdoc />
      public int LargestWindowHeight => Console.LargestWindowHeight;

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public bool NumberLock => Console.NumberLock;

      /// <inheritdoc />
      // ReSharper disable once AssignNullToNotNullAttribute
      public ITextWriter Out => Console.Out.ToInterface();

      /// <inheritdoc />
      public IEncoding OutputEncoding
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         get => Console.OutputEncoding.ToInterface();
         // ReSharper disable once AssignNullToNotNullAttribute
         set => Console.OutputEncoding = value.ToImplementation();
      }

#pragma warning disable CA1416
      /// <inheritdoc />
      public string Title
      {
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         get => Console.Title;
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         set => Console.Title = value;
      }
#pragma warning restore CA1416

      /// <inheritdoc />
      public bool TreatControlCAsInput
      {
         get => Console.TreatControlCAsInput;
         set => Console.TreatControlCAsInput = value;
      }

#pragma warning disable CA1416
      /// <inheritdoc />
      public int WindowHeight
      {
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         get => Console.WindowHeight;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.WindowHeight = value;
      }

      /// <inheritdoc />
      public int WindowWidth
      {
#if NET5_0
         [UnsupportedOSPlatform("browser")]
#endif
         get => Console.WindowWidth;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.WindowWidth = value;
      }

      /// <inheritdoc />
      public int WindowLeft
      {
         get => Console.WindowLeft;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.WindowLeft = value;
      }

      /// <inheritdoc />
      public int WindowTop
      {
         get => Console.WindowTop;
#if NET5_0
         [SupportedOSPlatform("windows")]
#endif
         set => Console.WindowTop = value;
      }
#pragma warning restore CA1416

      /// <inheritdoc />
#if NET5_0
      [UnsupportedOSPlatform("browser")]
#endif
      public void Beep()
      {
         Console.Beep();
      }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
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
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
      {
         Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
      }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
      {
         Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
      }

      /// <inheritdoc />
      public IStream OpenStandardError()
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         return Console.OpenStandardError().ToInterface();
      }

      /// <inheritdoc />
      public IStream OpenStandardError(int bufferSize)
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         return Console.OpenStandardError(bufferSize).ToInterface();
      }

      /// <inheritdoc />
      public IStream OpenStandardInput()
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         return Console.OpenStandardInput().ToInterface();
      }

      /// <inheritdoc />
      public IStream OpenStandardInput(int bufferSize)
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         return Console.OpenStandardInput(bufferSize).ToInterface();
      }

      /// <inheritdoc />
      public IStream OpenStandardOutput()
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         return Console.OpenStandardOutput().ToInterface();
      }

      /// <inheritdoc />
      public IStream OpenStandardOutput(int bufferSize)
      {
         // ReSharper disable once AssignNullToNotNullAttribute
         return Console.OpenStandardOutput(bufferSize).ToInterface();
      }

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
      public string? ReadLine()
      {
         return Console.ReadLine();
      }

      /// <inheritdoc />
      public void ResetColor()
      {
         Console.ResetColor();
      }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
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
         // ReSharper disable once AssignNullToNotNullAttribute
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
         // ReSharper disable once AssignNullToNotNullAttribute
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
         // ReSharper disable once AssignNullToNotNullAttribute
         Console.SetOut(newOut.ToImplementation());
      }

      /// <inheritdoc />
      public void SetOut(TextWriter newOut)
      {
         Console.SetOut(newOut);
      }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
      public void SetWindowPosition(int left, int top)
      {
         Console.SetWindowPosition(left, top);
      }

      /// <inheritdoc />
#if NET5_0
      [SupportedOSPlatform("windows")]
#endif
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
      public void Write(char[]? buffer)
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
      public void Write(object? value)
      {
         Console.Write(value);
      }

      /// <inheritdoc />
      public void Write(float value)
      {
         Console.Write(value);
      }

      /// <inheritdoc />
      public void Write(string? value)
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
      public void WriteLine(char[]? buffer)
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
      public void WriteLine(object? value)
      {
         Console.WriteLine(value);
      }

      /// <inheritdoc />
      public void WriteLine(float value)
      {
         Console.WriteLine(value);
      }

      /// <inheritdoc />
      public void WriteLine(string? value)
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

#if NET5_0
      [UnsupportedOSPlatform("browser")]
      public (int Left, int Top) GetCursorPosition()
      {
         return Console.GetCursorPosition();
      }
#endif
   }
}
