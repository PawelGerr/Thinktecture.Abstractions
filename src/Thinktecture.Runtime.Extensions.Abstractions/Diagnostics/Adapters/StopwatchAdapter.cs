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
		public Stopwatch InternalInstance { get; }

		/// <inheritdoc />
		public bool IsRunning => InternalInstance.IsRunning;

		/// <inheritdoc />
		public TimeSpan Elapsed => InternalInstance.Elapsed;

		/// <inheritdoc />
		public long ElapsedMilliseconds => InternalInstance.ElapsedMilliseconds;

		/// <inheritdoc />
		public long ElapsedTicks => InternalInstance.ElapsedTicks;

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

			InternalInstance = stopwatch;
		}

		/// <inheritdoc />
		public void Start()
		{
			InternalInstance.Start();
		}

		/// <inheritdoc />
		public void Stop()
		{
			InternalInstance.Stop();
		}

		/// <inheritdoc />
		public void Reset()
		{
			InternalInstance.Reset();
		}

		/// <inheritdoc />
		public void Restart()
		{
			InternalInstance.Reset();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return InternalInstance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return InternalInstance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}
	}
}