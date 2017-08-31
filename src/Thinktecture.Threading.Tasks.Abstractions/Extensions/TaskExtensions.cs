using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.Threading.Tasks;
using Thinktecture.Threading.Tasks.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Task"/> and <see cref="Task{TResult}"/>.
	/// </summary>
	public static class TaskExtensions
	{
		/// <summary>
		/// Converts <see cref="Task"/> to <see cref="ITask"/>.
		/// </summary>
		/// <param name="task"><see cref="Task"/> to convert.</param>
		/// <returns>Instance of <see cref="ITask"/>.</returns>
		[CanBeNull]
		public static ITask ToInterface([CanBeNull] this Task task)
		{
			return (task == null) ? null : new TaskAdapter(task);
		}

		/// <summary>
		/// Converts <see cref="Task{TResult}"/> to <see cref="ITask{TResult}"/>.
		/// </summary>
		/// <param name="task"><see cref="Task{TResult}"/> to convert.</param>
		/// <typeparam name="TResult">Type of the result.</typeparam>
		/// <returns>Instance of <see cref="ITask{TResult}"/>.</returns>
		[CanBeNull]
		public static ITask<TResult> ToInterface<TResult>([CanBeNull] this Task<TResult> task)
		{
			return (task == null) ? null : new TaskAdapter<TResult>(task);
		}

		/// <summary>
		/// Converts provided <see cref="ITask{TResult}"/> info to <see cref="Task"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="ITask{TResult}"/> to convert.</param>
		/// <typeparam name="TResult">Type of the result.</typeparam>
		/// <returns>An instance of <see cref="Task"/>.</returns>
		[CanBeNull]
		public static Task<TResult> ToImplementation<TResult>([CanBeNull] this ITask<TResult> abstraction)
		{
			return ((IAbstraction<Task<TResult>>)abstraction)?.UnsafeConvert();
		}
	}
}
