using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable MethodSupportsCancellation

namespace Thinktecture.Threading.Tasks.Adapters
{
	/// <summary>Provides support for creating and scheduling <see cref="ITask" /> objects. </summary>
	public class TaskFactoryAdapter : AbstractionAdapter<TaskFactory>, ITaskFactory
	{
		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the default configuration.</summary>
		public TaskFactoryAdapter()
			: this(new TaskFactory())
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another CancellationToken is explicitly specified while calling the factory methods.</param>
		public TaskFactoryAdapter(CancellationToken cancellationToken)
			: this(new TaskFactory(cancellationToken))
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to use to schedule any tasks created with this TaskFactory. A null value indicates that the current TaskScheduler should be used.</param>
		public TaskFactoryAdapter([CanBeNull] TaskScheduler scheduler)
			: this(new TaskFactory(scheduler))
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary>
		/// <param name="creationOptions">The default <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> to use when creating tasks with this TaskFactory.</param>
		/// <param name="continuationOptions">The default <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> to use when creating continuation tasks with this TaskFactory.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />. -or-The <paramref name="continuationOptions" /> argument specifies an invalid value.  </exception>
		public TaskFactoryAdapter(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
			: this(new TaskFactory(creationOptions, continuationOptions))
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory" /> instance with the specified configuration.</summary>
		/// <param name="cancellationToken">The default <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another CancellationToken is explicitly specified while calling the factory methods.</param>
		/// <param name="creationOptions">The default <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> to use when creating tasks with this TaskFactory.</param>
		/// <param name="continuationOptions">The default <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> to use when creating continuation tasks with this TaskFactory.</param>
		/// <param name="scheduler">The default <see cref="T:System.Threading.Tasks.TaskScheduler" /> to use to schedule any Tasks created with this TaskFactory. A null value indicates that TaskScheduler.Current should be used.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />. -or-The <paramref name="continuationOptions" /> argument specifies an invalid value.  </exception>
		public TaskFactoryAdapter(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, [CanBeNull] TaskScheduler scheduler)
			: this(new TaskFactory(cancellationToken, creationOptions, continuationOptions, scheduler))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="TaskFactoryAdapter"/>.
		/// </summary>
		/// <param name="factory">Factory to use by the adapter.</param>
		public TaskFactoryAdapter([NotNull] TaskFactory factory)
			: base(factory)
		{
		}

		/// <inheritdoc />
		public CancellationToken CancellationToken => Implementation.CancellationToken;

		/// <inheritdoc />
		public TaskScheduler Scheduler => Implementation.Scheduler;

		/// <inheritdoc />
		public TaskCreationOptions CreationOptions => Implementation.CreationOptions;

		/// <inheritdoc />
		public TaskContinuationOptions ContinuationOptions => Implementation.ContinuationOptions;

		/// <inheritdoc />
		public ITask StartNew(Action action)
		{
			return Implementation.StartNew(action).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action action, CancellationToken cancellationToken)
		{
			return Implementation.StartNew(action, cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action action, TaskCreationOptions creationOptions)
		{
			return Implementation.StartNew(action, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.StartNew(action, cancellationToken, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action<object> action, object state)
		{
			return Implementation.StartNew(action, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action<object> action, object state, CancellationToken cancellationToken)
		{
			return Implementation.StartNew(action, state, cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action<object> action, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.StartNew(action, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.StartNew(action, state, cancellationToken, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<TResult> function)
		{
			return Implementation.StartNew(function).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			return Implementation.StartNew(function, cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
		{
			return Implementation.StartNew(function, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.StartNew(function, cancellationToken, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<object, TResult> function, object state)
		{
			return Implementation.StartNew(function, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken)
		{
			return Implementation.StartNew(function, state, cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.StartNew(function, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.StartNew(function, state, cancellationToken, creationOptions, scheduler).ToInterface();
		}

#pragma warning disable RCS1047 // Non-asynchronous method name should not end with 'Async'.
		/// <inheritdoc />
		public ITask FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod)
		{
			return Implementation.FromAsync(asyncResult, endMethod).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(asyncResult, endMethod, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.FromAsync(asyncResult, endMethod, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
		{
			return Implementation.FromAsync(asyncResult, endMethod).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(asyncResult, endMethod, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.FromAsync(asyncResult, endMethod, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions).ToInterface();
		}
#pragma warning restore RCS1047 // Non-asynchronous method name should not end with 'Async'.

		/// <inheritdoc />
		public ITask ContinueWhenAll(Task[] tasks, Action<ITask[]> continuationAction)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(ITask[] tasks, Action<ITask[]> continuationAction)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(Task[] tasks, Action<ITask[]> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(ITask[] tasks, Action<ITask[]> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(Task[] tasks, Action<ITask[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(ITask[] tasks, Action<ITask[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(Task[] tasks, Action<ITask[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll(ITask[] tasks, Action<ITask[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<ITask[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(ITask[] tasks, Func<ITask[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(ITask[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(ITask[] tasks, Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TResult>(ITask[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(Task[] tasks, Action<ITask> continuationAction)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(ITask[] tasks, Action<ITask> continuationAction)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(Task[] tasks, Action<ITask> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(ITask[] tasks, Action<ITask> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(Task[] tasks, Action<ITask> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(ITask[] tasks, Action<ITask> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(Task[] tasks, Action<ITask> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny(ITask[] tasks, Action<ITask> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<ITask, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(ITask[] tasks, Func<ITask, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(ITask[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(ITask[] tasks, Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TResult>(ITask[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationAction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}
	}

	/// <summary>Provides support for creating and scheduling <see cref="ITask{TResult}" /> objects. </summary>
	/// <typeparam name="TResult">Type of the result.</typeparam>
	public class TaskFactoryAdapter<TResult> : AbstractionAdapter<TaskFactory<TResult>>, ITaskFactory<TResult>
	{
		/// <inheritdoc />
		public CancellationToken CancellationToken => Implementation.CancellationToken;

		/// <inheritdoc />
		public TaskContinuationOptions ContinuationOptions => Implementation.ContinuationOptions;

		/// <inheritdoc />
		public TaskCreationOptions CreationOptions => Implementation.CreationOptions;

		/// <inheritdoc />
		public TaskScheduler Scheduler => Implementation.Scheduler;

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the default configuration.</summary>
		public TaskFactoryAdapter()
			: this(new TaskFactory<TResult>())
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the default configuration.</summary>
		/// <param name="cancellationToken">The default cancellation token that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another cancellation token is explicitly specified when calling the factory methods.</param>
		public TaskFactoryAdapter(CancellationToken cancellationToken)
			: this(new TaskFactory<TResult>(cancellationToken))
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary>
		/// <param name="scheduler">The scheduler to use to schedule any tasks created with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />. A null value indicates that the current <see cref="T:System.Threading.Tasks.TaskScheduler" /> should be used.</param>
		public TaskFactoryAdapter(TaskScheduler scheduler)
			: this(new TaskFactory<TResult>(scheduler))
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary>
		/// <param name="creationOptions">The default options to use when creating tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <param name="continuationOptions">The default options to use when creating continuation tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="creationOptions" /> or <paramref name="continuationOptions" /> specifies an invalid value.</exception>
		public TaskFactoryAdapter(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
			: this(new TaskFactory<TResult>(creationOptions, continuationOptions))
		{
		}

		/// <summary>Initializes a <see cref="T:System.Threading.Tasks.TaskFactory`1" /> instance with the specified configuration.</summary>
		/// <param name="cancellationToken">The default cancellation token that will be assigned to tasks created by this <see cref="T:System.Threading.Tasks.TaskFactory" /> unless another cancellation token is explicitly specified when calling the factory methods.</param>
		/// <param name="creationOptions">The default options to use when creating tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <param name="continuationOptions">The default options to use when creating continuation tasks with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <param name="scheduler">The default scheduler to use to schedule any tasks created with this <see cref="T:System.Threading.Tasks.TaskFactory`1" />. A null value indicates that <see cref="P:System.Threading.Tasks.TaskScheduler.Current" /> should be used.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="creationOptions" /> or <paramref name="continuationOptions" /> specifies an invalid value.</exception>
		public TaskFactoryAdapter(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(new TaskFactory<TResult>(cancellationToken, creationOptions, continuationOptions, scheduler))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="TaskFactoryAdapter{TResult}"/>.
		/// </summary>
		/// <param name="factory">Factory to be used by the adapter.</param>
		public TaskFactoryAdapter([NotNull] TaskFactory<TResult> factory)
			: base(factory)
		{
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<TResult> function)
		{
			return Implementation.StartNew(function).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken)
		{
			return Implementation.StartNew(function, cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions)
		{
			return Implementation.StartNew(function, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.StartNew(function, cancellationToken, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<object, TResult> function, object state)
		{
			return Implementation.StartNew(function, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken)
		{
			return Implementation.StartNew(function, state, cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.StartNew(function, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.StartNew(function, state, cancellationToken, creationOptions, scheduler).ToInterface();
		}

#pragma warning disable RCS1047 // Non-asynchronous method name should not end with 'Async'.
		/// <inheritdoc />
		public ITask<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
		{
			return Implementation.FromAsync(asyncResult, endMethod).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(asyncResult, endMethod, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Implementation.FromAsync(asyncResult, endMethod, creationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, state, creationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			return Implementation.FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions).ToInterface();
		}
#pragma warning restore RCS1047 // Non-asynchronous method name should not end with 'Async'.

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(Task[] tasks, Func<ITask[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(ITask[] tasks, Func<ITask[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(Task[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(ITask[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(Task[] tasks, Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(ITask[] tasks, Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(Task[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll(ITask[] tasks, Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAll<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAll(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(Task[] tasks, Func<ITask, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(ITask[] tasks, Func<ITask, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(Task[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(ITask[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(Task[] tasks, Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(ITask[] tasks, Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(Task[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny(ITask[] tasks, Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask, Task>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface())).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), continuationOptions).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks, t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}

		/// <inheritdoc />
		public ITask<TResult> ContinueWhenAny<TAntecedentResult>(ITask<TAntecedentResult>[] tasks, Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return Implementation.ContinueWhenAny(tasks.ToImplementation<ITask<TAntecedentResult>, Task<TAntecedentResult>>(), t => continuationFunction(t.ToInterface()), cancellationToken, continuationOptions, scheduler).ToInterface();
		}
	}
}
