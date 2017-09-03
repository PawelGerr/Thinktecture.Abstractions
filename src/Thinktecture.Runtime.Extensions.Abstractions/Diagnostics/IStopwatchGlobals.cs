using System.Diagnostics;
using JetBrains.Annotations;

namespace Thinktecture.Diagnostics
{
	/// <summary>
	/// Statics of <see cref="Stopwatch"/>.
	/// </summary>
	public interface IStopwatchGlobals
	{
		/// <summary>
		/// Gets the frequency of the timer as the number of ticks per second.This field is read-only.
		/// </summary>
		long Frequency { get; }

		/// <summary>
		/// Indicates whether the timer is based on a high-resolution performance counter.This field is read-only.
		/// </summary>
		bool IsHighResolution { get; }

		/// <summary>
		/// Gets the current number of ticks in the timer mechanism.
		/// </summary>
		/// <returns>A long integer representing the tick counter value of the underlying timer mechanism.</returns>
		long GetTimestamp();

		/// <summary>
		/// Initializes a new Stopwatch instance, sets the elapsed time property to zero, and starts measuring elapsed time.
		/// </summary>
		/// <returns>A <see cref="IStopwatch"/> that has just begun measuring elapsed time.</returns>
		[NotNull]
		IStopwatch StartNew();
	}
}