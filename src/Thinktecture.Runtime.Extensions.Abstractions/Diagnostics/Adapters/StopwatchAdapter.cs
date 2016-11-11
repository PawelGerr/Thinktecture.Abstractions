using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Thinktecture.Diagnostics.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Stopwatch"/>.
	/// </summary>
	public class StopwatchAdapter : IStopwatch
	{
		/// <summary>
		/// Gets the frequency of the timer as the number of ticks per second.This field is read-only.
		/// </summary>
		public static long Frequency => Stopwatch.Frequency;

		/// <summary>
		/// Indicates whether the timer is based on a high-resolution performance counter.This field is read-only.
		/// </summary>
		public static bool IsHighResolution => Stopwatch.IsHighResolution;

		/// <summary>
		/// Gets the current number of ticks in the timer mechanism.
		/// </summary>
		/// <returns>A long integer representing the tick counter value of the underlying timer mechanism.</returns>
		public static long GetTimestamp()
		{
			return Stopwatch.GetTimestamp();
		}

		/// <summary>
		/// Initializes a new Stopwatch instance, sets the elapsed time property to zero, and starts measuring elapsed time.
		/// </summary>
		/// <returns>A <see cref="IStopwatch"/> that has just begun measuring elapsed time.</returns>
		public static IStopwatch StartNew()
		{
			return Stopwatch.StartNew().ToInterface();
		}

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Stopwatch UnsafeConvert()
		{
			return _instance;
		}

		private readonly Stopwatch _instance;

		/// <inheritdoc />
		public bool IsRunning => _instance.IsRunning;

		/// <inheritdoc />
		public TimeSpan Elapsed => _instance.Elapsed;

		/// <inheritdoc />
		public long ElapsedMilliseconds => _instance.ElapsedMilliseconds;

		/// <inheritdoc />
		public long ElapsedTicks => _instance.ElapsedTicks;

		/// <summary>
		///	Initializes a new instance of the <see cref="StopwatchAdapter"/> class.
		/// </summary>
		public StopwatchAdapter()
			: this(new Stopwatch())
		{
		}

		/// <summary>
		/// 	Initializes a new instance of the <see cref="StopwatchAdapter"/> class.
		/// </summary>
		/// <param name="stopwatch">Stopwatch to be use by the adapter.</param>
		public StopwatchAdapter(Stopwatch stopwatch)
		{
			if (stopwatch == null)
				throw new ArgumentNullException(nameof(stopwatch));

			_instance = stopwatch;
		}

		/// <inheritdoc />
		public void Start()
		{
			_instance.Start();
		}

		/// <inheritdoc />
		public void Stop()
		{
			_instance.Stop();
		}

		/// <inheritdoc />
		public void Reset()
		{
			_instance.Reset();
		}

		/// <inheritdoc />
		public void Restart()
		{
			_instance.Reset();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return _instance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return _instance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _instance.GetHashCode();
		}
	}
}