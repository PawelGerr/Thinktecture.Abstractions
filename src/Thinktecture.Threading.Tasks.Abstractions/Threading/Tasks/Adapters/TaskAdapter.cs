using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.Runtime.CompilerServices;

namespace Thinktecture.Threading.Tasks.Adapters
{
	/// <summary>
	/// Represents an asynchronous operation.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	[AsyncMethodBuilder(typeof(AsyncITaskMethodBuilder))]
	public class TaskAdapter : AbstractionAdapter, ITask
#if NET45
		, IDisposable
#endif
	{
		private readonly Task _task;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Task UnsafeConvert()
		{
			return _task;
		}

		/// <summary>Gets an ID for this <see cref="T:System.Threading.Tasks.Task" /> instance.</summary>
		/// <returns>The identifier that is assigned by the system to this <see cref="T:System.Threading.Tasks.Task" /> instance. </returns>
		public int Id => _task.Id;

		/// <summary>Returns the ID of the currently executing <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>An integer that was assigned by the system to the currently-executing task.</returns>
		public static int? CurrentId => Task.CurrentId;

		/// <summary>Gets the <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely. If the <see cref="T:System.Threading.Tasks.Task" /> completed successfully or has not yet thrown any exceptions, this will return null.</summary>
		/// <returns>The <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely.</returns>
		public AggregateException Exception => _task.Exception;

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task.</summary>
		/// <returns>The current <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task instance.</returns>
		public TaskStatus Status => _task.Status;

		/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> instance has completed execution due to being canceled.</summary>
		/// <returns>true if the task has completed due to being canceled; otherwise false.</returns>
		public bool IsCanceled => _task.IsCanceled;

		/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> has completed.</summary>
		/// <returns>true if the task has completed; otherwise false.</returns>
		public bool IsCompleted => _task.IsCompleted;

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</summary>
		/// <returns>The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</returns>
		public TaskCreationOptions CreationOptions => _task.CreationOptions;

		WaitHandle IAsyncResult.AsyncWaitHandle => ((IAsyncResult) _task).AsyncWaitHandle;

		/// <summary>Gets the state object supplied when the <see cref="T:System.Threading.Tasks.Task" /> was created, or null if none was supplied.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the state data that was passed in to the task when it was created.</returns>
		public object AsyncState => _task.AsyncState;

		bool IAsyncResult.CompletedSynchronously => ((IAsyncResult) _task).CompletedSynchronously;

		/// <summary>Provides access to factory methods for creating and configuring <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> objects. </returns>
		public static TaskFactory Factory => Task.Factory;

#if NETSTANDARD1_3 
		/// <summary>Gets a task that has already completed successfully. </summary>
		/// <returns>The successfully completed task. </returns>
		public static Task CompletedTask => Task.CompletedTask;
#endif

		/// <summary>Gets whether the <see cref="T:System.Threading.Tasks.Task" /> completed due to an unhandled exception.</summary>
		/// <returns>true if the task has thrown an unhandled exception; otherwise false.</returns>
		public bool IsFaulted => _task.IsFaulted;

		/// <summary>
		/// Initializes new intance of type <see cref="TaskAdapter"/>.
		/// </summary>
		/// <param name="task">Task to be used by the adapter.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		public TaskAdapter(Task task)
			: base(task)
		{
			_task = task;
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		public TaskAdapter(Action action)
			: this(new Task(action))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action and <see cref="CancellationToken" />.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken" /> that the new  task will observe.</param>
		/// <exception cref="ObjectDisposedException">The provided <see cref="CancellationToken" /> has already been disposed. </exception>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		public TaskAdapter(Action action, CancellationToken cancellationToken)
			: this(new Task(action, cancellationToken))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action and creation options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="creationOptions">The <see cref="TaskCreationOptions" /> used to customize the task's behavior. </param>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="TaskCreationOptions" />.</exception>
		public TaskAdapter(Action action, TaskCreationOptions creationOptions)
			: this(new Task(action, creationOptions))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action and creation options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="cancellationToken">The <see cref="TaskFactory.CancellationToken" /> that the new task will observe.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="ObjectDisposedException">The <see cref="CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="TaskCreationOptions" />.</exception>
		public TaskAdapter(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(new Task(action, cancellationToken, creationOptions))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action and state.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		public TaskAdapter(Action<object> action, object state)
			: this(new Task(action, state))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action, state, and options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <param name="cancellationToken">The <see cref="TaskFactory.CancellationToken" /> that that the new task will observe.</param>
		/// <exception cref="ObjectDisposedException">The <see cref="CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		public TaskAdapter(Action<object> action, object state, CancellationToken cancellationToken)
			: this(new Task(action, state, cancellationToken))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action, state, and options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <param name="creationOptions">The <see cref="TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="TaskCreationOptions" />.</exception>
		public TaskAdapter(Action<object> action, object state, TaskCreationOptions creationOptions)
			: this(new Task(action, state, creationOptions))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter" /> with the specified action, state, and options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <param name="cancellationToken">The <see cref="TaskFactory.CancellationToken" /> that that the new task will observe..</param>
		/// <param name="creationOptions">The <see cref="TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="ObjectDisposedException">The <see cref="CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="TaskCreationOptions" />.</exception>
		public TaskAdapter(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(new Task(action, state, cancellationToken, creationOptions))
		{
		}

		/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the current <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		public void Start()
		{
			_task.Start();
		}

		/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the specified <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> with which to associate and execute this task.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskSchedulerException">The scheduler was unable to queue this task.</exception>
		public void Start(TaskScheduler scheduler)
		{
			_task.Start(scheduler);
		}

		/// <summary>Runs the <see cref="T:System.Threading.Tasks.Task" /> synchronously on the current <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		public void RunSynchronously()
		{
			_task.RunSynchronously();
		}

		/// <summary>Runs the <see cref="T:System.Threading.Tasks.Task" /> synchronously on the <see cref="T:System.Threading.Tasks.TaskScheduler" /> provided.</summary>
		/// <param name="scheduler">The scheduler on which to attempt to run this task inline.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		public void RunSynchronously(TaskScheduler scheduler)
		{
			_task.RunSynchronously(scheduler);
		}

#if NET45
		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.Tasks.Task" /> class.</summary>
		/// <exception cref="T:System.InvalidOperationException">The task is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		public void Dispose()
		{
			_task.Dispose();
		}
#endif

		/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>An awaiter instance.</returns>
		public TaskAwaiter GetAwaiter()
		{
			return _task.GetAwaiter();
		}

		/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
		/// <returns>An object used to await this task.</returns>
		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return _task.ConfigureAwait(continueOnCapturedContext);
		}

		/// <summary>Creates an awaitable task that asynchronously yields back to the current context when awaited.</summary>
		/// <returns>A context that, when awaited, will asynchronously transition back into the current context at the time of the await. If the current <see cref="T:System.Threading.SynchronizationContext" /> is non-null, it is treated as the current context. Otherwise, the task scheduler that is associated with the currently executing task is treated as the current context. </returns>
		public static YieldAwaitable Yield()
		{
			return Task.Yield();
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		public void Wait()
		{
			_task.Wait();
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution within a specified time interval.</summary>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		public bool Wait(TimeSpan timeout)
		{
			return _task.Wait(timeout);
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution. The wait terminates if a cancellation token is canceled before the task completes. </summary>
		/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete. </param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The task has been disposed.</exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		public void Wait(CancellationToken cancellationToken)
		{
			_task.Wait(cancellationToken);
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution within a specified number of milliseconds.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		public bool Wait(int millisecondsTimeout)
		{
			return _task.Wait(millisecondsTimeout);
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution. The wait terminates if a timeout interval elapses or a cancellation token is canceled before the task completes. </summary>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete. </param>
		/// <returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return _task.Wait(millisecondsTimeout, cancellationToken);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task> continuationAction)
		{
			return _task.ContinueWith(continuationAction);
		}

		/// <summary>Creates a continuation that receives a cancellation token and executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created the token has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationAction, cancellationToken);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation uses a specified scheduler. </summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null. -or-The <paramref name="scheduler" /> argument is null.</exception>
		public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, scheduler);
		}

		/// <summary>Creates a continuation that executes when the target task completes according to the specified <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</summary>
		/// <param name="continuationAction">An action to run according to the specified <paramref name="continuationOptions" />. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationAction, continuationOptions);
		}

		/// <summary>Creates a continuation that executes when the target task competes according to the specified <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />. The continuation receives a cancellation token and uses a specified scheduler. </summary>
		/// <param name="continuationAction">An action to run according to the specified <paramref name="continuationOptions" />. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created the token has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes. </summary>
		/// <param name="continuationAction">An action to run when the task completes. When run, the delegate is passed the completed task and a caller-supplied state object as arguments. </param>
		/// <param name="state">An object representing data to be used by the continuation action. </param>
		/// <returns>A new continuation task. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state)
		{
			return _task.ContinueWith(continuationAction, state);
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and a cancellation token and that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationAction, state, cancellationToken);
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation uses a specified scheduler. </summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes.  When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, state, scheduler);
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation executes based on a set of specified conditions. </summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationAction, state, continuationOptions);
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and a cancellation token and that executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation executes based on a set of specified conditions and uses a specified scheduler. </summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, state, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes and returns a value. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" />  completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <typeparam name="TResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation task. </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction)
		{
			return _task.ContinueWith(continuationFunction);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes and returns a value. The continuation receives a cancellation token. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created the token has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationFunction, cancellationToken);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes and returns a value. The continuation uses a specified scheduler. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, scheduler);
		}

		/// <summary>Creates a continuation that executes according to the specified continuation options and returns a value. </summary>
		/// <param name="continuationFunction">A function to run according to the condition specified in <paramref name="continuationOptions" />. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationFunction, continuationOptions);
		}

		/// <summary>Creates a continuation that executes according to the specified continuation options and returns a value. The continuation is passed a cancellation token and uses a specified scheduler. </summary>
		/// <param name="continuationFunction">A function to run according to the specified <paramref name="continuationOptions." /> When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created the token has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Creates a continuation that receives caller-supplied state information and executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes and returns a value. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task and the caller-supplied state object as arguments. </param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <typeparam name="TResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state)
		{
			return _task.ContinueWith(continuationFunction, state);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes and returns a value. The continuation receives caller-supplied state information and a cancellation token. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationFunction, state, cancellationToken);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation receives caller-supplied state information and uses a specified scheduler. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes.  When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, state, scheduler);
		}

		/// <summary>Creates a continuation that executes based on the specified task continuation options when the target <see cref="T:System.Threading.Tasks.Task" /> completes. The continuation receives caller-supplied state information. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationFunction, state, continuationOptions);
		}

		/// <summary>Creates a continuation that executes based on the specified task continuation options when the target <see cref="T:System.Threading.Tasks.Task" /> completes and returns a value. The continuation receives caller-supplied state information and a cancellation token and uses the specified scheduler. </summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
		/// <typeparam name="TResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, state, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> exception contains an <see cref="T:System.OperationCanceledException" /> exception in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. </exception>
		public static void WaitAll(params Task[] tasks)
		{
			Task.WaitAll(tasks);
		}

		/// <summary>Waits for all of the provided cancellable <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null. </exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		public static bool WaitAll(Task[] tasks, TimeSpan timeout)
		{
			return Task.WaitAll(tasks, timeout);
		}

		/// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection. -or-An exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout)
		{
			return Task.WaitAll(tasks, millisecondsTimeout);
		}

		/// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution unless the wait is cancelled. </summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		public static void WaitAll(Task[] tasks, CancellationToken cancellationToken)
		{
			Task.WaitAll(tasks, cancellationToken);
		}

		/// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified number of milliseconds or until the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.-or-An exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.-or-The <paramref name="tasks" /> argument is an empty array.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return Task.WaitAll(tasks, millisecondsTimeout, cancellationToken);
		}

		/// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <returns>The index of the completed <see cref="T:System.Threading.Tasks.Task" /> object in the <paramref name="tasks" /> array.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public static int WaitAny(params Task[] tasks)
		{
			return Task.WaitAny(tasks);
		}

		/// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified time interval.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out. -or-<paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public static int WaitAny(Task[] tasks, TimeSpan timeout)
		{
			return Task.WaitAny(tasks, timeout);
		}

		/// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution unless the wait is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		public static int WaitAny(Task[] tasks, CancellationToken cancellationToken)
		{
			return Task.WaitAny(tasks, cancellationToken);
		}

		/// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		public static int WaitAny(Task[] tasks, int millisecondsTimeout)
		{
			return Task.WaitAny(tasks, millisecondsTimeout);
		}

		/// <summary>Waits for any of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified number of milliseconds or until a cancellation token is cancelled.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for a task to complete. </param>
		/// <returns>The index of the completed task in the <paramref name="tasks" /> array argument, or -1 if the timeout occurred.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled. </exception>
		public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return Task.WaitAny(tasks, millisecondsTimeout, cancellationToken);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed successfully with the specified result.</summary>
		/// <param name="result">The result to store into the completed task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The successfully completed task.</returns>
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			return Task.FromResult(result);
		}

#if NETSTANDARD1_3 /// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that has completed with a specified exception. </summary>
/// <param name="exception">The exception with which to complete the task. </param>
/// <returns>The faulted task. </returns>
		public static Task FromException(Exception exception)
		{
			return Task.FromException(exception);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed with a specified exception. </summary>
		/// <param name="exception">The exception with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The faulted task. </returns>
		public static Task<TResult> FromException<TResult>(Exception exception)
		{
			return Task.FromException<TResult>(exception);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is false. </exception>
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			return Task.FromCanceled(cancellationToken);
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed due to cancellation with a specified cancellation token.</summary>
		/// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
		/// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
		/// <returns>The canceled task. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Cancellation has not been requested for <paramref name="cancellationToken" />; its <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> property is false. </exception>
		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return Task.FromCanceled<TResult>(cancellationToken);
		}
#endif

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task" /> object that represents that work.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <returns>A task that represents the work queued to execute in the ThreadPool.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		public static Task Run(Action action)
		{
			return Task.Run(action);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task" /> object that represents that work. A cancellation token allows the work to be cancelled.</summary>
		/// <param name="action">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that can be used to cancel the work</param>
		/// <returns>A task that represents the work queued to execute in the thread pool.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public static Task Run(Action action, CancellationToken cancellationToken)
		{
			return Task.Run(action, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a <see cref="T:System.Threading.Tasks.Task`1" /> object that represents that work. </summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <typeparam name="TResult">The return type of the task. </typeparam>
		/// <returns>A task object that represents the work queued to execute in the thread pool. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter is null. </exception>
		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			return Task.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a Task(TResult) object that represents that work. A cancellation token allows the work to be cancelled.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The result type of the task.</typeparam>
		/// <returns>A Task(TResult) that represents the work queued to execute in the thread pool.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter is null.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			return Task.Run(function, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public static Task Run(Func<Task> function)
		{
			return Task.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the task returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously. </param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work. </param>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			return Task.Run(function, cancellationToken);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return Task.Run(function);
		}

		/// <summary>Queues the specified work to run on the thread pool and returns a proxy for the Task(TResult) returned by <paramref name="function" />.</summary>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			return Task.Run(function, cancellationToken);
		}

		/// <summary>Creates a task that completes after a specified time interval. </summary>
		/// <param name="delay">The time span to wait before completing the returned task, or TimeSpan.FromMilliseconds(-1) to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="delay" /> represents a negative time interval other than TimeSpan.FromMillseconds(-1). -or-The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		public static Task Delay(TimeSpan delay)
		{
			return Task.Delay(delay);
		}

		/// <summary>Creates a cancellable task that completes after a specified time interval. </summary>
		/// <param name="delay">The time span to wait before completing the returned task, or TimeSpan.FromMilliseconds(-1) to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="delay" /> represents a negative time interval other than TimeSpan.FromMillseconds(-1). -or-The <paramref name="delay" /> argument's <see cref="P:System.TimeSpan.TotalMilliseconds" /> property is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		public static Task Delay(TimeSpan delay, CancellationToken cancellationToken)
		{
			return Task.Delay(delay, cancellationToken);
		}

		/// <summary>Creates a task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1.</exception>
		public static Task Delay(int millisecondsDelay)
		{
			return Task.Delay(millisecondsDelay);
		}

		/// <summary>Creates a cancellable task that completes after a time delay. </summary>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task, or -1 to wait indefinitely. </param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task. </param>
		/// <returns>A task that represents the time delay. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> argument is less than -1. </exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed. </exception>
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			return Task.Delay(millisecondsDelay, cancellationToken);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="T:System.Threading.Tasks.Task" /> objects in an enumerable collection have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		public static Task WhenAll(IEnumerable<Task> tasks)
		{
			return Task.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="T:System.Threading.Tasks.Task" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task. </exception>
		public static Task WhenAll(params Task[] tasks)
		{
			return Task.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="T:System.Threading.Tasks.Task`1" /> objects in an enumerable collection have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion. </param>
		/// <typeparam name="TResult">The type of the completed task. </typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task. </exception>
		public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return Task.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when all of the <see cref="T:System.Threading.Tasks.Task`1" /> objects in an array have completed. </summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks)
		{
			return Task.WhenAll(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return Task.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			return Task.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks)
		{
			return Task.WhenAny(tasks);
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return Task.WhenAny(tasks);
		}
	}

	/// <summary>
	/// Represents an asynchronous operation.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	[AsyncMethodBuilder(typeof(AsyncITaskMethodBuilder<>))]
	public class TaskAdapter<TResult> : TaskAdapter, ITask<TResult>
	{
		private readonly Task<TResult> _task;

		/// <summary>Gets the result value of this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>The result value of this <see cref="T:System.Threading.Tasks.Task`1" />, which is the same type as the task's type parameter.</returns>
		/// <exception cref="T:System.AggregateException">The task was canceled. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains a <see cref="T:System.Threading.Tasks.TaskCanceledException" /> object. -or-An exception was thrown during the execution of the task. The <see cref="P:System.AggregateException.InnerExceptions" /> collection contains information about the exception or exceptions. </exception>
		public TResult Result => _task.Result;

		/// <summary>Provides access to factory methods for creating and configuring <see cref="TaskAdapter{TResult}" /> instances.</summary>
		/// <returns>A factory object that can create a variety of <see cref="TaskAdapter{TResult}" /> objects.</returns>
		public new static TaskFactory<TResult> Factory => Task<TResult>.Factory;

		/// <summary>Initializes a new <see cref="TaskAdapter{TResult}" />.</summary>
		/// <param name="task">Task to be used by adapter.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="task" /> argument is null.</exception>
		public TaskAdapter(Task<TResult> task)
			: base(task)
		{
			_task = task;
		}

		/// <summary>Initializes a new <see cref="TaskAdapter{TResult}" /> with the specified function.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="TaskAdapter{TResult}.Result" /> property will be set to return the result value of the function.</param>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<TResult> function)
			: this(new Task<TResult>(function))
		{
		}

		/// <summary>Initializes a new <see cref="TaskAdapter{TResult}" /> with the specified function.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="TaskAdapter{TResult}.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken" /> to be assigned to this task.</param>
		/// <exception cref="ObjectDisposedException">The <see cref="CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<TResult> function, CancellationToken cancellationToken)
			: this(new Task<TResult>(function, cancellationToken))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified function and creation options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<TResult> function, TaskCreationOptions creationOptions)
			: this(new Task<TResult>(function, creationOptions))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified function and creation options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new task.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(new Task<TResult>(function, cancellationToken, creationOptions))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified function and state.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<object, TResult> function, object state)
			: this(new Task<TResult>(function, state))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified action, state, and options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="state">An object representing data to be used by the function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to the new task.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<object, TResult> function, object state, CancellationToken cancellationToken)
			: this(new Task<TResult>(function, state, cancellationToken))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified action, state, and options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="state">An object representing data to be used by the function.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
			: this(new Task<TResult>(function, state, creationOptions))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified action, state, and options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="state">An object representing data to be used by the function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to the new task.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public TaskAdapter(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(new Task<TResult>(function, state, cancellationToken, creationOptions))
		{
		}

		/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>An awaiter instance.</returns>
		public new TaskAwaiter<TResult> GetAwaiter()
		{
			return _task.GetAwaiter();
		}

		/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
		/// <returns>An object used to await this task.</returns>
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return _task.ConfigureAwait(continueOnCapturedContext);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target task completes. </summary>
		/// <param name="continuationAction">An action to run when the antecedent <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <returns>A new continuation task. </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null. </exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction)
		{
			return _task.ContinueWith(continuationAction);
		}

		/// <summary>Creates a cancelable continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate is passed the completed task as an argument. </param>
		/// <param name="cancellationToken">The cancellation token that is passed to the new continuation task. </param>
		/// <returns>A new continuation task. </returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null. </exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationAction, cancellationToken);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, scheduler);
		}

		/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationAction">An action to according the condition specified in <paramref name="continuationOptions" />. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationAction, continuationOptions);
		}

		/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationAction">An action to run according the condition specified in <paramref name="continuationOptions" />. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Creates a continuation that that is passed state information and that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes. </summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate is   passed the completed task and the caller-supplied state object as arguments. </param>
		/// <param name="state">An object representing data to be used by the continuation action. </param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state)
		{
			return _task.ContinueWith(continuationAction, state);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationAction, state, cancellationToken);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null. </exception>
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, state, scheduler);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such  as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationAction, state, continuationOptions);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as  well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationAction, state, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction)
		{
			return _task.ContinueWith(continuationFunction);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new task.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationFunction, cancellationToken);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, scheduler);
		}

		/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationFunction">A function to run according the condition specified in <paramref name="continuationOptions" />.When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationFunction, continuationOptions);
		}

		/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationFunction">A function to run according the condition specified in <paramref name="continuationOptions" />.When run, the delegate will be passed as an argument this completed task.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, cancellationToken, continuationOptions, scheduler);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <typeparam name="TNewResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state)
		{
			return _task.ContinueWith(continuationFunction, state);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new task.</param>
		/// <typeparam name="TNewResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken)
		{
			return _task.ContinueWith(continuationFunction, state, cancellationToken);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TNewResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, state, scheduler);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TNewResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
		{
			return _task.ContinueWith(continuationFunction, state, continuationOptions);
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <typeparam name="TNewResult">The type of the result produced by the continuation.</typeparam>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The  <paramref name="continuationOptions" />  argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return _task.ContinueWith(continuationFunction, state, cancellationToken, continuationOptions, scheduler);
		}
	}
}