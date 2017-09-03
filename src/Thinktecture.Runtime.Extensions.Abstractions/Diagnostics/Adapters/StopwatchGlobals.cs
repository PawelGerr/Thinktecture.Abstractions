using System.Diagnostics;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Diagnostics.Adapters
{
	/// <summary>
	/// Statics of <see cref="Stopwatch"/>.
	/// </summary>
	public class StopwatchGlobals : IStopwatchGlobals
	{
		/// <summary>
		/// Gets the frequency of the timer as the number of ticks per second.This field is read-only.
		/// </summary>
		public long Frequency => StopwatchAdapter.Frequency;

		/// <summary>
		/// Indicates whether the timer is based on a high-resolution performance counter.This field is read-only.
		/// </summary>
		public bool IsHighResolution => StopwatchAdapter.IsHighResolution;

		/// <summary>
		/// Gets the current number of ticks in the timer mechanism.
		/// </summary>
		/// <returns>A long integer representing the tick counter value of the underlying timer mechanism.</returns>
		public long GetTimestamp()
		{
			return StopwatchAdapter.GetTimestamp();
		}

		/// <summary>
		/// Initializes a new Stopwatch instance, sets the elapsed time property to zero, and starts measuring elapsed time.
		/// </summary>
		/// <returns>A <see cref="IStopwatch"/> that has just begun measuring elapsed time.</returns>
		public IStopwatch StartNew()
		{
			return StopwatchAdapter.StartNew();
		}
	}
}
