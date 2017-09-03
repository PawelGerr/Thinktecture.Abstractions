using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.Threading.Tasks
{
	/// <summary>
	/// Statics fo <see cref="Task{TResult}"/>
	/// </summary>
	/// <typeparam name="TResult">Type of the result.</typeparam>
	public interface ITaskGlobals<TResult> : ITaskGlobals
	{
		/// <summary>Provides access to factory methods for creating and configuring <see cref="ITask{TResult}" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="ITask{TResult}" /> objects.</returns>
		[NotNull]
		new ITaskFactory<TResult> Factory { get; }
	}

	/// <summary>
	/// Statics of <see cref="Task"/>
	/// </summary>
	public interface ITaskGlobals
	{
		/// <summary>Returns the ID of the currently executing <see cref="Task" />.</summary>
		/// <returns>An integer that was assigned by the system to the currently-executing task.</returns>
		int? CurrentId { get; }

		/// <summary>Provides access to factory methods for creating and configuring <see cref="Task" /> and <see cref="Task{TResult}" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="Task" /> and <see cref="Task{TResult}" /> objects. </returns>
		[NotNull]
		ITaskFactory Factory { get; }

#if NETSTANDARD1_3
		/// <summary>Gets a task that has already completed successfully. </summary>
		/// <returns>The successfully completed task. </returns>
		[NotNull]
		ITask CompletedTask { get; }
#endif

		/// <summary>Creates an awaitable task that asynchronously yields back to the current context when awaited.</summary>
		/// <returns>A context that, when awaited, will asynchronously transition back into the current context at the time of the await. If the current <see cref="T:System.Threading.SynchronizationContext" /> is non-null, it is treated as the current context. Otherwise, the task scheduler that is associated with the currently executing task is treated as the current context. </returns>
		YieldAwaitable Yield();

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> exception contains an <see cref="T:System.OperationCanceledException" /> exception in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		void WaitAll([NotNull] params Task[] tasks);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> exception contains an <see cref="T:System.OperationCanceledException" /> exception in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		void WaitAll([NotNull] params ITask[] tasks);

		/// <summary>Waits for all of the provided cancellable <see cref="Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>true if all of the <see cref="Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null. </exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		bool WaitAll([NotNull] Task[] tasks, TimeSpan timeout);

		/// <summary>Waits for all of the provided cancellable <see cref="Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>true if all of the <see cref="Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null. </exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		bool WaitAll([NotNull] ITask[] tasks, TimeSpan timeout);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>true if all of the <see cref="Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection. -or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		bool WaitAll([NotNull] Task[] tasks, int millisecondsTimeout);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>true if all of the <see cref="Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection. -or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		bool WaitAll([NotNull] ITask[] tasks, int millisecondsTimeout);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled. </summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		void WaitAll([NotNull] Task[] tasks, CancellationToken cancellationToken);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled. </summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		void WaitAll([NotNull] ITask[] tasks, CancellationToken cancellationToken);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds or until the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <returns>true if all of the <see cref="Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		bool WaitAll([NotNull] Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds or until the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <returns>true if all of the <see cref="Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		bool WaitAll([NotNull] ITask[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <returns>The index of the completed <see cref="Task" /> object in the <paramref name="tasks" /> array.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		int WaitAny([NotNull] params Task[] tasks);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <returns>The index of the completed <see cref="Task" /> object in the <paramref name="tasks" /> array.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		int WaitAny([NotNull] params ITask[] tasks);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		int WaitAny([NotNull] Task[] tasks, TimeSpan timeout);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		int WaitAny([NotNull] ITask[] tasks, TimeSpan timeout);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		int WaitAny([NotNull] Task[] tasks, CancellationToken cancellationToken);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		int WaitAny([NotNull] ITask[] tasks, CancellationToken cancellationToken);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		int WaitAny([NotNull] Task[] tasks, int millisecondsTimeout);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		int WaitAny([NotNull] ITask[] tasks, int millisecondsTimeout);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds or until a cancellation token is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		int WaitAny([NotNull] Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds or until a cancellation token is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		int WaitAny([NotNull] ITask[] tasks, int millisecondsTimeout, CancellationToken cancellationToken);

		/// <summary>Creates a <see cref="Task{TResult}" /> that's completed successfully with the specified result.</summary>
		/// <param name="result">The result to store into the completed task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The successfully completed task.</returns>
		[NotNull]
		ITask<TResult> FromResult<TResult>(TResult result);

#if NETSTANDARD1_3
		/// <summary>Creates a <see cref="Task" /> that has completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <returns>The faulted task. </returns>
		[NotNull]
		ITask FromException([NotNull] Exception exception);

		/// <summary>Creates a <see cref="Task{TResult}" /> that's completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The faulted task. </returns>
		[NotNull]
		ITask<TResult> FromException<TResult>([NotNull] Exception exception);

		/// <summary>Creates a <see cref="Task" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is false. </exception>
		[NotNull]
		ITask FromCanceled(CancellationToken cancellationToken);

		/// <summary>Creates a <see cref="Task{TResult}" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is false. </exception>
		[NotNull]
		ITask<TResult> FromCanceled<TResult>(CancellationToken cancellationToken);
#endif

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="Task" /> object that represents that work.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <returns>A task that represents the work queued to execute in the ThreadPool.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		[NotNull]
		ITask Run([NotNull] Action action);

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="Task" /> object that represents that work. A cancellation token allows the work to be cancelled.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
		/// <returns>A task that represents the work queued to execute in the thread pool.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		[NotNull]
		ITask Run([NotNull] Action action, CancellationToken cancellationToken);

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="Task{TResult}" /> object that represents that work. </summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <typeparam name="TResult">The return type of the task. </typeparam>
		/// <returns>A task object that represents the work queued to execute in the thread pool. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter is null. </exception>
		[NotNull]
		ITask<TResult> Run<TResult>([NotNull] Func<TResult> function);

		/// <summary>Queues the specified work to run on the thread pool and returns a Task(TResult) object that represents that work. A cancellation token allows the work to be cancelled.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The result type of the task.</typeparam>
		/// <returns>A Task(TResult) that represents the work queued to execute in the thread pool.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter is null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		[NotNull]
		ITask<TResult> Run<TResult>([NotNull] Func<TResult> function, CancellationToken cancellationToken);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		[NotNull]
		ITask Run([NotNull] Func<Task> function);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		[NotNull]
		ITask Run([NotNull] Func<ITask> function);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work. </param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		[NotNull]
		ITask Run([NotNull] Func<Task> function, CancellationToken cancellationToken);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work. </param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		[NotNull]
		ITask Run([NotNull] Func<ITask> function, CancellationToken cancellationToken);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		[NotNull]
		ITask<TResult> Run<TResult>([NotNull] Func<Task<TResult>> function);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		[NotNull]
		ITask<TResult> Run<TResult>([NotNull] Func<ITask<TResult>> function);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		[NotNull]
		ITask<TResult> Run<TResult>([NotNull] Func<Task<TResult>> function, CancellationToken cancellationToken);

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		[NotNull]
		ITask<TResult> Run<TResult>([NotNull] Func<ITask<TResult>> function, CancellationToken cancellationToken);

		/// <summary>Creates a task that completes after a specified time interval. </summary>
		/// <param name="delay">The time span to wait before completing the returned task, or TimeSpan.FromMilliseconds(-1) to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="delay" /> represents a negative time interval other than TimeSpan.FromMillseconds(-1). -or-The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		[NotNull]
		ITask Delay(TimeSpan delay);

		/// <summary>Creates a cancellable task that completes after a specified time interval. </summary>
		/// <param name="delay">The time span to wait before completing the returned task, or TimeSpan.FromMilliseconds(-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="delay" /> represents a negative time interval other than TimeSpan.FromMillseconds(-1). -or-The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		[NotNull]
		ITask Delay(TimeSpan delay, CancellationToken cancellationToken);

		/// <summary>Creates a task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1.</exception>
		[NotNull]
		ITask Delay(int millisecondsDelay);

		/// <summary>Creates a cancellable task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1. </exception>
		/// <exception cref="TaskCanceledException">The task has been canceled. </exception>
		/// <exception cref="ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		[NotNull]
		ITask Delay(int millisecondsDelay, CancellationToken cancellationToken);

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an enumerable collection have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		[NotNull]
		ITask WhenAll(IEnumerable<Task> tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an enumerable collection have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		[NotNull]
		ITask WhenAll([NotNull, ItemNotNull] IEnumerable<ITask> tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task. </exception>
		[NotNull]
		ITask WhenAll([NotNull, ItemNotNull] params Task[] tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task. </exception>
		[NotNull]
		ITask WhenAll([NotNull, ItemNotNull] params ITask[] tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an enumerable collection have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion. </param>
		/// <typeparam name="TResult">The type of the completed task. </typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task. </exception>
		[NotNull]
		Task<TResult[]> WhenAll<TResult>([NotNull, ItemNotNull] IEnumerable<Task<TResult>> tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an enumerable collection have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion. </param>
		/// <typeparam name="TResult">The type of the completed task. </typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task. </exception>
		[NotNull]
		Task<TResult[]> WhenAll<TResult>([NotNull, ItemNotNull] IEnumerable<ITask<TResult>> tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		[NotNull]
		Task<TResult[]> WhenAll<TResult>([NotNull, ItemNotNull] params Task<TResult>[] tasks);

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		[NotNull]
		Task<TResult[]> WhenAll<TResult>([NotNull, ItemNotNull] params ITask<TResult>[] tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task> WhenAny([NotNull, ItemNotNull] params Task[] tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task> WhenAny([NotNull, ItemNotNull] params ITask[] tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task> WhenAny([NotNull, ItemNotNull] IEnumerable<Task> tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task> WhenAny([NotNull, ItemNotNull] IEnumerable<ITask> tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task<TResult>> WhenAny<TResult>([NotNull, ItemNotNull] params Task<TResult>[] tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task<TResult>> WhenAny<TResult>([NotNull, ItemNotNull] params ITask<TResult>[] tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task<TResult>> WhenAny<TResult>([NotNull, ItemNotNull] IEnumerable<Task<TResult>> tasks);

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		[NotNull]
		Task<Task<TResult>> WhenAny<TResult>([NotNull, ItemNotNull] IEnumerable<ITask<TResult>> tasks);
	}
}
