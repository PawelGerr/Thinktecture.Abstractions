using System;
using System.Runtime.CompilerServices;

namespace Thinktecture.Runtime.CompilerServices
{
	/// <summary>
	/// An interface of the <see cref="AsyncTaskMethodBuilder"/> for easier implementation of method builders.
	/// </summary>
	/// <typeparam name="TTask">Type of the task-like type.</typeparam>
	public interface IAsyncTaskMethodBuilder<out TTask>
	{
		/// <summary>
		/// Gets the task for this builder.
		/// </summary>
		TTask Task { get; }

		/// <summary>
		/// Begins running the builder with the associated state machine.
		/// </summary>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		/// <exception cref="ArgumentNullException"><paramref name="stateMachine" /> is null.</exception>
		void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine;

		/// <summary>
		/// Associates the builder with the specified state machine.
		/// </summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		/// <exception cref="ArgumentNullException"><paramref name="stateMachine" /> is null.</exception>
		/// <exception cref="InvalidOperationException">The state machine was previously set.</exception>
		void SetStateMachine(IAsyncStateMachine stateMachine);

		/// <summary>
		/// Schedules the state machine to proceed to the next action when the specified awaiter completes.
		/// </summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine;

		/// <summary>
		/// Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.
		/// </summary>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine;

		/// <summary>
		/// Marks the task as successfully completed.
		/// </summary>
		/// <exception cref="InvalidOperationException">The task has already completed.</exception>
		void SetResult();

		/// <summary>
		/// Marks the task as failed and binds the specified exception to the task.
		/// </summary>
		/// <param name="exception">The exception to bind to the task.</param>
		/// <exception cref="ArgumentNullException"><paramref name="exception" /> is null.</exception>
		/// <exception cref="InvalidOperationException">The task has already completed.</exception>
		void SetException(Exception exception);
	}

	/// <summary>
	/// An interface of the <see cref="AsyncTaskMethodBuilder{TResult}"/> for easier implementation of method builders.
	/// </summary>
	/// <typeparam name="TTask">Type of the task</typeparam>
	/// <typeparam name="TResult">Type of the return type of the task.</typeparam>
	public interface IAsyncTaskMethodBuilder<out TTask, in TResult>
	{
		/// <summary>
		/// Gets the task for this builder.
		/// </summary>
		TTask Task { get; }

		/// <summary>Begins running the builder with the associated state machine.</summary>
		/// <param name="stateMachine">The state machine instance, passed by reference.</param>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		/// <exception cref="ArgumentNullException"><paramref name="stateMachine" /> is null.</exception>
		void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine;

		/// <summary>
		/// Associates the builder with the specified state machine.
		/// </summary>
		/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
		/// <exception cref="ArgumentNullException"><paramref name="stateMachine" /> is null.</exception>
		/// <exception cref="InvalidOperationException">The state machine was previously set.</exception>
		void SetStateMachine(IAsyncStateMachine stateMachine);

		/// <summary>
		/// Schedules the state machine to proceed to the next action when the specified awaiter completes.
		/// </summary>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine;

		/// <summary>
		/// Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.
		/// </summary>
		/// <param name="awaiter">The awaiter.</param>
		/// <param name="stateMachine">The state machine.</param>
		/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
		/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
		void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine;

		/// <summary>
		/// Marks the task as successfully completed.
		/// </summary>
		/// <param name="result">The result to use to complete the task.</param>
		/// <exception cref="InvalidOperationException">The task has already completed.</exception>
		void SetResult(TResult result);

		/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
		/// <param name="exception">The exception to bind to the task.</param>
		/// <exception cref="ArgumentNullException"><paramref name="exception" /> is null.</exception>
		/// <exception cref="InvalidOperationException">The task has already completed.</exception>
		void SetException(Exception exception);
	}
}