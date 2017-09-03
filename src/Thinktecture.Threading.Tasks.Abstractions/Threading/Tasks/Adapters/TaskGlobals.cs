using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable ConstantConditionalAccessQualifier
// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable TaskOfTMethodsWithoutAsyncSuffix

namespace Thinktecture.Threading.Tasks.Adapters
{
	/// <summary>
	/// Statics fo <see cref="Task{TResult}"/>
	/// </summary>
	/// <typeparam name="TResult">Type of the result.</typeparam>
	public class TaskGlobals<TResult> : TaskGlobals, ITaskGlobals<TResult>
	{
		/// <summary>Provides access to factory methods for creating and configuring <see cref="TaskAdapter{TResult}" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="TaskAdapter{TResult}" /> objects.</returns>
		public new ITaskFactory<TResult> Factory => TaskAdapter<TResult>.Factory;
	}

	/// <summary>
	/// Statics of <see cref="Task"/>
	/// </summary>
	public class TaskGlobals : ITaskGlobals
	{
		/// <summary>Returns the ID of the currently executing <see cref="Task" />.</summary>
		/// <returns>An integer that was assigned by the system to the currently-executing task.</returns>
		public int? CurrentId => TaskAdapter.CurrentId;

		/// <summary>Provides access to factory methods for creating and configuring <see cref="Task" /> and <see cref="Task{TResult}" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="Task" /> and <see cref="Task{TResult}" /> objects. </returns>
		public ITaskFactory Factory => TaskAdapter.Factory;

#if NETSTANDARD1_3
		/// <summary>Gets a task that has already completed successfully. </summary>
		/// <returns>The successfully completed task. </returns>
		public ITask CompletedTask => TaskAdapter.CompletedTask;
#endif

		/// <summary>Creates an awaitable task that asynchronously yields back to the current context when awaited.</summary>
		/// <returns>A context that, when awaited, will asynchronously transition back into the current context at the time of the await. If the current <see cref="T:System.Threading.SynchronizationContext" /> is non-null, it is treated as the current context. Otherwise, the task scheduler that is associated with the currently executing task is treated as the current context. </returns>
		public YieldAwaitable Yield()
		{
			return TaskAdapter.Yield();
		}

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> exception contains an <see cref="T:System.OperationCanceledException" /> exception in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		public void WaitAll(params Task[] tasks)
		{
			TaskAdapter.WaitAll(tasks);
		}

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> exception contains an <see cref="T:System.OperationCanceledException" /> exception in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		public void WaitAll(params ITask[] tasks)
		{
			TaskAdapter.WaitAll(tasks);
		}

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
		public bool WaitAll(Task[] tasks, TimeSpan timeout)
		{
			return TaskAdapter.WaitAll(tasks, timeout);
		}

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
		public bool WaitAll(ITask[] tasks, TimeSpan timeout)
		{
			return TaskAdapter.WaitAll(tasks, timeout);
		}

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
		public bool WaitAll(Task[] tasks, int millisecondsTimeout)
		{
			return TaskAdapter.WaitAll(tasks, millisecondsTimeout);
		}

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
		public bool WaitAll(ITask[] tasks, int millisecondsTimeout)
		{
			return TaskAdapter.WaitAll(tasks, millisecondsTimeout);
		}

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled. </summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		public void WaitAll(Task[] tasks, CancellationToken cancellationToken)
		{
			TaskAdapter.WaitAll(tasks, cancellationToken);
		}

		/// <summary>Waits for all of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled. </summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="ObjectDisposedException">One or more of the <see cref="Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		public void WaitAll(ITask[] tasks, CancellationToken cancellationToken)
		{
			TaskAdapter.WaitAll(tasks, cancellationToken);
		}

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
		public bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return TaskAdapter.WaitAll(tasks, millisecondsTimeout, cancellationToken);
		}

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
		public bool WaitAll(ITask[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return TaskAdapter.WaitAll(tasks, millisecondsTimeout, cancellationToken);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <returns>The index of the completed <see cref="Task" /> object in the <paramref name="tasks" /> array.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public int WaitAny(params Task[] tasks)
		{
			return TaskAdapter.WaitAny(tasks);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <returns>The index of the completed <see cref="Task" /> object in the <paramref name="tasks" /> array.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public int WaitAny(params ITask[] tasks)
		{
			return TaskAdapter.WaitAny(tasks);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public int WaitAny(Task[] tasks, TimeSpan timeout)
		{
			return TaskAdapter.WaitAny(tasks, timeout);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public int WaitAny(ITask[] tasks, TimeSpan timeout)
		{
			return TaskAdapter.WaitAny(tasks, timeout);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		public int WaitAny(Task[] tasks, CancellationToken cancellationToken)
		{
			return TaskAdapter.WaitAny(tasks, cancellationToken);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution unless the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		public int WaitAny(ITask[] tasks, CancellationToken cancellationToken)
		{
			return TaskAdapter.WaitAny(tasks, cancellationToken);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public int WaitAny(Task[] tasks, int millisecondsTimeout)
		{
			return TaskAdapter.WaitAny(tasks, millisecondsTimeout);
		}

		/// <summary>Waits for any of the provided <see cref="Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="ObjectDisposedException">The <see cref="Task" /> has been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public int WaitAny(ITask[] tasks, int millisecondsTimeout)
		{
			return TaskAdapter.WaitAny(tasks, millisecondsTimeout);
		}

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
		public int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return TaskAdapter.WaitAny(tasks, millisecondsTimeout, cancellationToken);
		}

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
		public int WaitAny(ITask[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return TaskAdapter.WaitAny(tasks, millisecondsTimeout, cancellationToken);
		}

		/// <summary>Creates a <see cref="Task{TResult}" /> that's completed successfully with the specified result.</summary>
		/// <param name="result">The result to store into the completed task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The successfully completed task.</returns>
		public ITask<TResult> FromResult<TResult>(TResult result)
		{
			return TaskAdapter.FromResult(result);
		}

#if NETSTANDARD1_3
		/// <summary>Creates a <see cref="Task" /> that has completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <returns>The faulted task. </returns>
		public ITask FromException(Exception exception)
		{
			return TaskAdapter.FromException(exception);
		}

		/// <summary>Creates a <see cref="Task{TResult}" /> that's completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The faulted task. </returns>
		public ITask<TResult> FromException<TResult>(Exception exception)
		{
			return TaskAdapter.FromException<TResult>(exception);
		}

		/// <summary>Creates a <see cref="Task" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is false. </exception>
		public ITask FromCanceled(CancellationToken cancellationToken)
		{
			return TaskAdapter.FromCanceled(cancellationToken);
		}

		/// <summary>Creates a <see cref="Task{TResult}" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is false. </exception>
		public ITask<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return TaskAdapter.FromCanceled<TResult>(cancellationToken);
		}
#endif

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="Task" /> object that represents that work.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <returns>A task that represents the work queued to execute in the ThreadPool.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		public ITask Run(Action action)
		{
			return TaskAdapter.Run(action);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="Task" /> object that represents that work. A cancellation token allows the work to be cancelled.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
		/// <returns>A task that represents the work queued to execute in the thread pool.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public ITask Run(Action action, CancellationToken cancellationToken)
		{
			return TaskAdapter.Run(action, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="Task{TResult}" /> object that represents that work. </summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <typeparam name="TResult">The return type of the task. </typeparam>
		/// <returns>A task object that represents the work queued to execute in the thread pool. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter is null. </exception>
		public ITask<TResult> Run<TResult>(Func<TResult> function)
		{
			return TaskAdapter.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a Task(TResult) object that represents that work. A cancellation token allows the work to be cancelled.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The result type of the task.</typeparam>
		/// <returns>A Task(TResult) that represents the work queued to execute in the thread pool.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter is null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public ITask<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			return TaskAdapter.Run(function, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public ITask Run(Func<Task> function)
		{
			return TaskAdapter.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public ITask Run(Func<ITask> function)
		{
			return TaskAdapter.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work. </param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public ITask Run(Func<Task> function, CancellationToken cancellationToken)
		{
			return TaskAdapter.Run(function, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work. </param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public ITask Run(Func<ITask> function, CancellationToken cancellationToken)
		{
			return TaskAdapter.Run(function, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public ITask<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return TaskAdapter.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public ITask<TResult> Run<TResult>(Func<ITask<TResult>> function)
		{
			return TaskAdapter.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public ITask<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			return TaskAdapter.Run(function, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public ITask<TResult> Run<TResult>(Func<ITask<TResult>> function, CancellationToken cancellationToken)
		{
			return TaskAdapter.Run(function, cancellationToken);
		}

		/// <summary>Creates a task that completes after a specified time interval. </summary>
		/// <param name="delay">The time span to wait before completing the returned task, or TimeSpan.FromMilliseconds(-1) to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="delay" /> represents a negative time interval other than TimeSpan.FromMillseconds(-1). -or-The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		public ITask Delay(TimeSpan delay)
		{
			return TaskAdapter.Delay(delay);
		}

		/// <summary>Creates a cancellable task that completes after a specified time interval. </summary>
		/// <param name="delay">The time span to wait before completing the returned task, or TimeSpan.FromMilliseconds(-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="delay" /> represents a negative time interval other than TimeSpan.FromMillseconds(-1). -or-The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		public ITask Delay(TimeSpan delay, CancellationToken cancellationToken)
		{
			return TaskAdapter.Delay(delay, cancellationToken);
		}

		/// <summary>Creates a task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1.</exception>
		public ITask Delay(int millisecondsDelay)
		{
			return TaskAdapter.Delay(millisecondsDelay);
		}

		/// <summary>Creates a cancellable task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1. </exception>
		/// <exception cref="TaskCanceledException">The task has been canceled. </exception>
		/// <exception cref="ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		public ITask Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			return TaskAdapter.Delay(millisecondsDelay, cancellationToken);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an enumerable collection have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		public ITask WhenAll(IEnumerable<Task> tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an enumerable collection have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		public ITask WhenAll(IEnumerable<ITask> tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task. </exception>
		public ITask WhenAll(params Task[] tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task. </exception>
		public ITask WhenAll(params ITask[] tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an enumerable collection have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion. </param>
		/// <typeparam name="TResult">The type of the completed task. </typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task. </exception>
		public Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an enumerable collection have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion. </param>
		/// <typeparam name="TResult">The type of the completed task. </typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task. </exception>
		public Task<TResult[]> WhenAll<TResult>(IEnumerable<ITask<TResult>> tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		public Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="Task{TResult}" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		public Task<TResult[]> WhenAll<TResult>(params ITask<TResult>[] tasks)
		{
			return TaskAdapter.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task> WhenAny(params Task[] tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task> WhenAny(params ITask[] tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task> WhenAny(IEnumerable<ITask> tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task<TResult>> WhenAny<TResult>(params ITask<TResult>[] tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public Task<Task<TResult>> WhenAny<TResult>(IEnumerable<ITask<TResult>> tasks)
		{
			return TaskAdapter.WhenAny(tasks);
		}
	}
}
