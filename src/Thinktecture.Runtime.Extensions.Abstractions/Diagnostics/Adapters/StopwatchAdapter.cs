using System;
using System.Diagnostics;

namespace Thinktecture.Diagnostics.Adapters
{
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

		private readonly Stopwatch _stopwatch;

		/// <inheritdoc />
		public bool IsRunning => _stopwatch.IsRunning;

		/// <inheritdoc />
		public TimeSpan Elapsed => _stopwatch.Elapsed;

		/// <inheritdoc />
		public long ElapsedMilliseconds => _stopwatch.ElapsedMilliseconds;

		/// <inheritdoc />
		public long ElapsedTicks => _stopwatch.ElapsedTicks;

		/// <summary>
		///	Initializes a new instance of the <see cref="Stopwatch"/> class.
		/// </summary>
		public StopwatchAdapter()
			: this(new Stopwatch())
		{
		}

		public StopwatchAdapter(Stopwatch stopwatch)
		{
			if (stopwatch == null)
				throw new ArgumentNullException(nameof(stopwatch));

			_stopwatch = stopwatch;
		}

		/// <inheritdoc />
		public Stopwatch ToImplementation()
		{
			return _stopwatch;
		}

		/// <inheritdoc />
		public void Start()
		{
			_stopwatch.Start();
		}

		/// <inheritdoc />
		public void Stop()
		{
			_stopwatch.Stop();
		}

		/// <inheritdoc />
		public void Reset()
		{
			_stopwatch.Reset();
		}

		/// <inheritdoc />
		public void Restart()
		{
			_stopwatch.Reset();
		}
	}
}