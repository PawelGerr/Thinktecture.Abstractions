using System;
using System.Diagnostics;

namespace Thinktecture.Diagnostics.Adapters
{
	public class StopwatchAdapter : IStopwatch
	{
		private readonly Stopwatch _stopwatch;

		/// <inheritdoc />
		public bool IsRunning => _stopwatch.IsRunning;

		/// <inheritdoc />
		public TimeSpan Elapsed => _stopwatch.Elapsed;

		/// <inheritdoc />
		public long ElapsedMilliseconds => _stopwatch.ElapsedMilliseconds;

		/// <inheritdoc />
		public long ElapsedTicks => _stopwatch.ElapsedTicks;

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