using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using JetBrains.Annotations;
using Thinktecture.Threading.Tasks;
using Thinktecture.Threading.Tasks.Adapters;

namespace Thinktecture.Runtime.CompilerServices
{
	/// <summary>
	/// Method builder for <see cref="ITask"/>.
	/// </summary>
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncITaskMethodBuilder : IAsyncTaskMethodBuilder<ITask>
	{
		private AsyncTaskMethodBuilder _methodBuilder;

		/// <summary>Gets the task for this builder.</summary>
		[NotNull]
		public ITask Task => new TaskAdapter(_methodBuilder.Task);

		/// <summary>Creates an instance of the <see cref="AsyncITaskMethodBuilder"/> struct.</summary>
		/// <returns>A new instance of the builder.</returns>
		public static AsyncITaskMethodBuilder Create()
		{
			return new AsyncITaskMethodBuilder()
			{
				_methodBuilder = AsyncTaskMethodBuilder.Create()
			};
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.Start(ref stateMachine);
		}

		/// <summary>Associates the builder with the specified state machine.</summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_methodBuilder.SetStateMachine(stateMachine);
		}

		/// <summary>Marks the task as successfully completed.</summary>
		public void SetResult()
		{
			_methodBuilder.SetResult();
		}

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		public void SetException(Exception exception)
		{
			_methodBuilder.SetException(exception);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitOnCompleted(ref awaiter, ref stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
		}
	}

	/// <summary>
	/// Method builder for <see cref="TaskAdapter"/>.
	/// </summary>
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncTaskAdapterMethodBuilder : IAsyncTaskMethodBuilder<TaskAdapter>
	{
		private AsyncTaskMethodBuilder _methodBuilder;

		/// <summary>Gets the task for this builder.</summary>
		[NotNull]
		public TaskAdapter Task => new TaskAdapter(_methodBuilder.Task);

		/// <summary>Creates an instance of the <see cref="AsyncTaskAdapterMethodBuilder"/> struct.</summary>
		/// <returns>A new instance of the builder.</returns>
		public static AsyncTaskAdapterMethodBuilder Create()
		{
			return new AsyncTaskAdapterMethodBuilder()
			{
				_methodBuilder = AsyncTaskMethodBuilder.Create()
			};
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.Start(ref stateMachine);
		}

		/// <summary>Associates the builder with the specified state machine.</summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_methodBuilder.SetStateMachine(stateMachine);
		}

		/// <summary>Marks the task as successfully completed.</summary>
		public void SetResult()
		{
			_methodBuilder.SetResult();
		}

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		public void SetException(Exception exception)
		{
			_methodBuilder.SetException(exception);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitOnCompleted(ref awaiter, ref stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
		}
	}

	/// <summary>
	/// Method builder for <see cref="ITask{TResult}"/>.
	/// </summary>
	/// <typeparam name="TResult">Type of the result.</typeparam>
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncITaskMethodBuilder<TResult> : IAsyncTaskMethodBuilder<ITask<TResult>, TResult>
	{
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		/// <summary>Gets the task for this builder.</summary>
		[NotNull]
		public ITask<TResult> Task => new TaskAdapter<TResult>(_methodBuilder.Task);

		/// <summary>Creates an instance of the <see cref="AsyncITaskMethodBuilder"/> struct.</summary>
		/// <returns>A new instance of the builder.</returns>
		public static AsyncITaskMethodBuilder<TResult> Create()
		{
			return new AsyncITaskMethodBuilder<TResult>()
			{
				_methodBuilder = AsyncTaskMethodBuilder<TResult>.Create()
			};
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.Start(ref stateMachine);
		}

		/// <summary>Associates the builder with the specified state machine.</summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_methodBuilder.SetStateMachine(stateMachine);
		}

		/// <summary>Marks the task as successfully completed.</summary>
		/// <param name="result">The result to set.</param>
		public void SetResult(TResult result)
		{
			_methodBuilder.SetResult(result);
		}

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		public void SetException(Exception exception)
		{
			_methodBuilder.SetException(exception);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitOnCompleted(ref awaiter, ref stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
		}
	}

	/// <summary>
	/// Method builder for <see cref="ITask{TResult}"/>.
	/// </summary>
	/// <typeparam name="TResult">Type of the result.</typeparam>
	[StructLayout(LayoutKind.Auto)]
	public struct AsyncTaskAdapterMethodBuilder<TResult> : IAsyncTaskMethodBuilder<TaskAdapter<TResult>, TResult>
	{
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		/// <summary>Gets the task for this builder.</summary>
		[NotNull]
		public TaskAdapter<TResult> Task => new TaskAdapter<TResult>(_methodBuilder.Task);

		/// <summary>Creates an instance of the <see cref="AsyncTaskAdapterMethodBuilder"/> struct.</summary>
		/// <returns>A new instance of the builder.</returns>
		public static AsyncTaskAdapterMethodBuilder<TResult> Create()
		{
			return new AsyncTaskAdapterMethodBuilder<TResult>()
			{
				_methodBuilder = AsyncTaskMethodBuilder<TResult>.Create()
			};
		}

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.Start(ref stateMachine);
		}

		/// <summary>Associates the builder with the specified state machine.</summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_methodBuilder.SetStateMachine(stateMachine);
		}

		/// <summary>Marks the task as successfully completed.</summary>
		/// <param name="result">The result to set.</param>
		public void SetResult(TResult result)
		{
			_methodBuilder.SetResult(result);
		}

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		public void SetException(Exception exception)
		{
			_methodBuilder.SetException(exception);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitOnCompleted(ref awaiter, ref stateMachine);
		}

		/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">the awaiter</param>
		/// <param name="stateMachine">The state machine.</param>
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine
		{
			_methodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
		}
	}
}
