using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Thinktecture.Threading.Tasks
{
	/// <summary>Provides support for creating and scheduling <see cref="T:System.Threading.Tasks.Task" /> objects. </summary>
	public interface ITaskFactory
	{
		/// <summary>Gets the default cancellation token for this task factory.</summary>
		/// <returns>The default task cancellation token for this task factory.</returns>
		CancellationToken CancellationToken { get; }

		/// <summary>Gets the default task scheduler for this task factory.</summary>
		/// <returns>The default task scheduler for this task factory.</returns>
		TaskScheduler Scheduler { get; }

		/// <summary>Gets the default task creation options for this task factory.</summary>
		/// <returns>The default task creation options for this task factory.</returns>
		TaskCreationOptions CreationOptions { get; }

		/// <summary>Gets the default task continuation options for this task factory.</summary>
		/// <returns>The default task continuation options for this task factory.</returns>
		TaskContinuationOptions ContinuationOptions { get; }

		/// <summary>Creates and starts a task.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		[NotNull]
		ITask StartNew([NotNull] Action action);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception>
		[NotNull]
		ITask StartNew([NotNull] Action action, CancellationToken cancellationToken);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value.</exception>
		[NotNull]
		ITask StartNew([NotNull] Action action, TaskCreationOptions creationOptions);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask StartNew([NotNull] Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />. </summary>
		/// <param name="action">The action delegate to execute asynchronously. </param>
		/// <param name="state">An object containing data to be used by the <paramref name="action" /> delegate. </param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is <see langword="null" />. </exception>
		[NotNull]
		ITask StartNew([NotNull] Action<object> action, object state);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="action" /> delegate.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception>
		[NotNull]
		ITask StartNew([NotNull] Action<object> action, object state, CancellationToken cancellationToken);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="action" /> delegate.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value.</exception>
		[NotNull]
		ITask StartNew([NotNull] Action<object> action, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">The action delegate to execute asynchronously.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="action" /> delegate.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="action" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask StartNew([NotNull] Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />. </typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<TResult> function);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />. </typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<TResult> function, CancellationToken cancellationToken);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<TResult> function, TaskCreationOptions creationOptions);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="function" /> delegate.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<object, TResult> function, object state);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="function" /> delegate.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new <see cref="T:System.Threading.Tasks.Task" /></param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<object, TResult> function, object state, CancellationToken cancellationToken);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="function" /> delegate.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<object, TResult> function, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates and starts a <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="function" /> delegate.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new task.</param>
		/// <param name="creationOptions">A TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="function" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> StartNew<TResult>([NotNull] Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that executes an end method action when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The IAsyncResult whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The action delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="asyncResult" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask FromAsync([NotNull] IAsyncResult asyncResult, [NotNull] Action<IAsyncResult> endMethod);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that executes an end method action when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The IAsyncResult whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The action delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="asyncResult" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask FromAsync([NotNull] IAsyncResult asyncResult, [NotNull] Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that executes an end method action when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The IAsyncResult whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The action delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the task that executes the end method.</param>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="asyncResult" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask FromAsync([NotNull] IAsyncResult asyncResult, [NotNull] Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask FromAsync([NotNull] Func<AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value.</exception>
		[NotNull]
		ITask FromAsync([NotNull] Func<AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask FromAsync<TArg1>([NotNull] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, TArg1 arg1, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask FromAsync<TArg1>([NotNull] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask FromAsync<TArg1, TArg2>([NotNull] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask FromAsync<TArg1, TArg2>([NotNull] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg3">The third argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the third argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg3">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask FromAsync<TArg1, TArg2, TArg3>([NotNull] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg3">The third argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the third argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg3">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask FromAsync<TArg1, TArg2, TArg3>([NotNull] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that executes an end method function when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The IAsyncResult whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The function delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="asyncResult" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TResult>([NotNull] IAsyncResult asyncResult, [NotNull] Func<IAsyncResult, TResult> endMethod);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that executes an end method function when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The IAsyncResult whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The function delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="asyncResult" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> FromAsync<TResult>([NotNull] IAsyncResult asyncResult, [NotNull] Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that executes an end method function when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The IAsyncResult whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The function delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the task that executes the end method.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="asyncResult" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> FromAsync<TResult>([NotNull] IAsyncResult asyncResult, [NotNull] Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TResult>([NotNull] Func<AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> FromAsync<TResult>([NotNull] Func<AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TResult>([NotNull] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TResult>([NotNull] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2, TResult>([NotNull] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2, TResult>([NotNull] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg3">The third argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the third argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg3">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>([NotNull] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state);

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg3">The third argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">The TaskCreationOptions value that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the third argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg3">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TResult">The type of the result available through the <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="beginMethod" /> argument is null.-or-The exception that is thrown when the <paramref name="endMethod" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. The exception that is thrown when the <paramref name="creationOptions" /> argument specifies an invalid TaskCreationOptions value. For more information, see the Remarks for <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" /></exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>([NotNull] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Action<ITask[]> continuationAction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Action<ITask[]> continuationAction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Action<ITask[]> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Action<ITask[]> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Action<ITask[]> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Action<ITask[]> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task.</param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Action<ITask[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task.</param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Action<ITask[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported.</param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationAction">The action delegate to execute when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported.</param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationAction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported.</param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported.</param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that starts when a set of specified tasks has completed.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token to assign to the new continuation task.</param>
		/// <param name="continuationOptions">A bitwise combination of the enumeration values that control the behavior of the new continuation task. The NotOn* and OnlyOn* members are not supported. </param>
		/// <param name="scheduler">The object that is used to schedule the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created task.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array is empty or contains a null value.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value. </exception>
		/// <exception cref="T:System.ObjectDisposedException">An element in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />. -or-The <paramref name="continuationAction" /> argument is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a <see langword="null" /> value. -or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Action<ITask> continuationAction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />. -or-The <paramref name="continuationAction" /> argument is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a <see langword="null" /> value. -or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Action<ITask> continuationAction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed. -or-
		/// <paramref name="cancellationToken" /> has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />. -or-The <paramref name="continuationAction" /> argument is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a <see langword="null" /> value. -or-The <paramref name="tasks" /> array is empty .</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Action<ITask> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed. -or-
		/// <paramref name="cancellationToken" /> has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />. -or-The <paramref name="continuationAction" /> argument is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a <see langword="null" /> value. -or-The <paramref name="tasks" /> array is empty .</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Action<ITask> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Action<ITask> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Action<ITask> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Action<ITask> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Action<ITask> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.-or-The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.-or-The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TResult>([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.-or-The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.-or-The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task`1" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">The type of the result that is returned by the <paramref name="continuationFunction" /> delegate and associated with the created <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationFunction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult, TResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.-or-The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.-or-The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The exception that is thrown when one of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The exception that is thrown when the <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation <see cref="T:System.Threading.Tasks.Task" /> that will be started upon the completion of any Task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationAction">The action delegate to execute when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">The <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value that controls the behavior of the created continuation <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The exception that is thrown when the <paramref name="tasks" /> array is null.-or-The exception that is thrown when the <paramref name="continuationAction" /> argument is null.-or-The exception that is thrown when the <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The exception that is thrown when the <paramref name="tasks" /> array contains a null value.-or-The exception that is thrown when the <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Action<ITask<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);
	}

	/// <summary>Provides support for creating and scheduling <see cref="T:System.Threading.Tasks.Task`1" /> objects.</summary>
	/// <typeparam name="TResult">The return value of the <see cref="T:System.Threading.Tasks.Task`1" /> objects that the methods of this class create. </typeparam>
	public interface ITaskFactory<TResult>
	{
		/// <summary>Gets the default cancellation token for this task factory.</summary>
		/// <returns>The default cancellation token for this task factory.</returns>
		CancellationToken CancellationToken { get; }

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> enumeration value for this task factory.</summary>
		/// <returns>One of the enumeration values that specifies the default continuation options for this task factory.</returns>
		TaskContinuationOptions ContinuationOptions { get; }

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> enumeration value for this task factory.</summary>
		/// <returns>One of the enumeration values that specifies the default creation options for this task factory.</returns>
		TaskCreationOptions CreationOptions { get; }

		/// <summary>Gets the task scheduler for this task factory.</summary>
		/// <returns>The task scheduler for this task factory.</returns>
		TaskScheduler Scheduler { get; }

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<TResult> function);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new task.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The cancellation token source that created<paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<TResult> function, CancellationToken cancellationToken);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <returns>The started <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<TResult> function, TaskCreationOptions creationOptions);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new task.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <param name="scheduler">The task scheduler that is used to schedule the created task.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The cancellation token source that created<paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="state">An object that contains data to be used by the <paramref name="function" /> delegate.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<object, TResult> function, object state);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="state">An object that contains data to be used by the <paramref name="function" /> delegate.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new task.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The cancellation token source that created<paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<object, TResult> function, object state, CancellationToken cancellationToken);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="state">An object that contains data to be used by the <paramref name="function" /> delegate.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<object, TResult> function, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates and starts a task.</summary>
		/// <param name="function">A function delegate that returns the future result to be available through the task.</param>
		/// <param name="state">An object that contains data to be used by the <paramref name="function" /> delegate.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new task.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <param name="scheduler">The task scheduler that is used to schedule the created task.</param>
		/// <returns>The started task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The cancellation token source that created<paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> StartNew([NotNull] Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a task that executes an end method function when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The function delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> FromAsync([NotNull] IAsyncResult asyncResult, [NotNull] Func<IAsyncResult, TResult> endMethod);

		/// <summary>Creates a task that executes an end method function when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The function delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <returns>A task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> FromAsync([NotNull] IAsyncResult asyncResult, [NotNull] Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions);

		/// <summary>Creates a task that executes an end method function when a specified <see cref="T:System.IAsyncResult" /> completes.</summary>
		/// <param name="asyncResult">The <see cref="T:System.IAsyncResult" /> whose completion should trigger the processing of the <paramref name="endMethod" />.</param>
		/// <param name="endMethod">The function delegate that processes the completed <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <param name="scheduler">The task scheduler that is used to schedule the task that executes the end method.</param>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> FromAsync([NotNull] IAsyncResult asyncResult, [NotNull] Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> FromAsync([NotNull] Func<AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, object state);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <returns>The created <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> FromAsync([NotNull] Func<AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1>([NotNull] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">One of the enumeration values that controls the behavior of the created task.</param>
		/// <typeparam name="TArg1">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1>([NotNull] Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2>([NotNull] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">An object that controls the behavior of the created <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2>([NotNull] Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg3">The third argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the third argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg3">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2, TArg3>([NotNull] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state);

		/// <summary>Creates a task that represents a pair of begin and end methods that conform to the Asynchronous Programming Model pattern.</summary>
		/// <param name="beginMethod">The delegate that begins the asynchronous operation.</param>
		/// <param name="endMethod">The delegate that ends the asynchronous operation.</param>
		/// <param name="arg1">The first argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg2">The second argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="arg3">The third argument passed to the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="state">An object containing data to be used by the <paramref name="beginMethod" /> delegate.</param>
		/// <param name="creationOptions">An object that controls the behavior of the created task.</param>
		/// <typeparam name="TArg1">The type of the second argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg2">The type of the third argument passed to <paramref name="beginMethod" /> delegate.</typeparam>
		/// <typeparam name="TArg3">The type of the first argument passed to the <paramref name="beginMethod" /> delegate.</typeparam>
		/// <returns>The created task that represents the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="beginMethod" /> argument is <see langword="null" />.-or-The <paramref name="endMethod" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> parameter specifies an invalid value.</exception>
		[NotNull]
		ITask<TResult> FromAsync<TArg1, TArg2, TArg3>([NotNull] Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, [NotNull] Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-
		/// <paramref name="continuationFunction" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-
		/// <paramref name="continuationFunction" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided Tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided Tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided Tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <param name="scheduler">The scheduler that is used to schedule the created continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="continuationOptions" /> specifies an invalid value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] Task[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided Tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <param name="scheduler">The scheduler that is used to schedule the created continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="continuationOptions" /> specifies an invalid value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll([NotNull] ITask[] tasks, [NotNull] Func<ITask[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <param name="scheduler">The scheduler that is used to schedule the created continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of a set of provided tasks.</summary>
		/// <param name="tasks">The array of tasks from which to continue.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when all tasks in the <paramref name="tasks" /> array have completed.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The NotOn* or OnlyOn* values are not valid.</param>
		/// <param name="scheduler">The scheduler that is used to schedule the created continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAll<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value or is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is null.-or-The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is null.-or-The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid enumeration value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid enumeration value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <param name="scheduler">The task scheduler that is used to schedule the created continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed. </exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] Task[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <param name="scheduler">The task scheduler that is used to schedule the created continuation task.</param>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed. </exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny([NotNull] ITask[] tasks, [NotNull] Func<ITask, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation task.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid enumeration value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid enumeration value.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed. </exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] Task<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);

		/// <summary>Creates a continuation task that will be started upon the completion of any task in the provided set.</summary>
		/// <param name="tasks">The array of tasks from which to continue when one task completes.</param>
		/// <param name="continuationFunction">The function delegate to execute asynchronously when one task in the <paramref name="tasks" /> array completes.</param>
		/// <param name="cancellationToken">The cancellation token that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">One of the enumeration values that controls the behavior of the created continuation task. The <see langword="NotOn*" /> or <see langword="OnlyOn*" /> values are not valid.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> that is used to schedule the created continuation <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">The type of the result of the antecedent <paramref name="tasks" />.</typeparam>
		/// <returns>The new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> array is <see langword="null" />.-or-The <paramref name="continuationFunction" /> argument is <see langword="null" />.-or-The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contains a null value.-or-The <paramref name="tasks" /> array is empty.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid TaskContinuationOptions value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">One of the elements in the <paramref name="tasks" /> array has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed. </exception>
		[NotNull]
		ITask<TResult> ContinueWhenAny<TAntecedentResult>([NotNull] ITask<TAntecedentResult>[] tasks, [NotNull] Func<ITask<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, [NotNull] TaskScheduler scheduler);
	}
}
