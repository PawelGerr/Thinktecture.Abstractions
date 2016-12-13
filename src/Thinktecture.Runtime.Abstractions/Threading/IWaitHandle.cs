using System;
using System.Threading;

namespace Thinktecture.Threading
{
	/// <summary>Encapsulates operating system–specific objects that wait for exclusive access to shared resources.</summary>
	/// <filterpriority>2</filterpriority>
	public interface IWaitHandle : IAbstraction<WaitHandle>, IDisposable
	{
		/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal.</summary>
		/// <returns>true if the current instance receives a signal. If the current instance is never signaled, <see cref="M:System.Threading.WaitHandle.WaitOne(System.Int32,System.Boolean)" /> never returns.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		/// <filterpriority>2</filterpriority>
		bool WaitOne();

		/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval in milliseconds.</summary>
		/// <returns>true if the current instance receives a signal; otherwise, false.</returns>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		bool WaitOne(int millisecondsTimeout);

		/// <summary>Blocks the current thread until the current instance receives a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval.</summary>
		/// <returns>true if the current instance receives a signal; otherwise, false.</returns>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely. </param>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out.-or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
		/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
		bool WaitOne(TimeSpan timeout);
	}
}