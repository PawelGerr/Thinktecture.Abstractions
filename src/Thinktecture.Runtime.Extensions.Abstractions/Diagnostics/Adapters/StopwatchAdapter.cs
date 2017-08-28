using System;
using System.Diagnostics;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Diagnostics.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Stopwatch"/>.
	/// </summary>
	public class StopwatchAdapter : AbstractionAdapter<Stopwatch>, IStopwatch
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
		[NotNull]
		public static IStopwatch StartNew()
		{
			return Stopwatch.StartNew().ToInterface();
		}

		/// <inheritdoc />
		public bool IsRunning => Implementation.IsRunning;

		/// <inheritdoc />
		public TimeSpan Elapsed => Implementation.Elapsed;

		/// <inheritdoc />
		public long ElapsedMilliseconds => Implementation.ElapsedMilliseconds;

		/// <inheritdoc />
		public long ElapsedTicks => Implementation.ElapsedTicks;

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
		public StopwatchAdapter([NotNull] Stopwatch stopwatch)
			: base(stopwatch)
		{
		}

		/// <inheritdoc />
		public void Start()
		{
			Implementation.Start();
		}

		/// <inheritdoc />
		public void Stop()
		{
			Implementation.Stop();
		}

		/// <inheritdoc />
		public void Reset()
		{
			Implementation.Reset();
		}

		/// <inheritdoc />
		public void Restart()
		{
			Implementation.Reset();
		}
	}
}
