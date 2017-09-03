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
	public static class TaskFactoryExtensions
	{
		/// <summary>
		/// Converts <see cref="TaskFactory"/> to <see cref="ITaskFactory"/>.
		/// </summary>
		/// <param name="task"><see cref="TaskFactory"/> to convert.</param>
		/// <returns>Instance of <see cref="ITaskFactory"/>.</returns>
		[CanBeNull]
		public static ITaskFactory ToInterface([CanBeNull] this TaskFactory task)
		{
			if (task == null)
				return null;

			if (ReferenceEquals(task, Task.Factory))
				return TaskAdapter.Factory;

			return new TaskFactoryAdapter(task);
		}

		/// <summary>
		/// Converts <see cref="TaskFactory{TResult}"/> to <see cref="ITaskFactory{TResult}"/>.
		/// </summary>
		/// <param name="task"><see cref="TaskFactory{TResult}"/> to convert.</param>
		/// <typeparam name="TResult">Type of the result.</typeparam>
		/// <returns>Instance of <see cref="ITaskFactory{TResult}"/>.</returns>
		[CanBeNull]
		public static ITaskFactory<TResult> ToInterface<TResult>([CanBeNull] this TaskFactory<TResult> task)
		{
			if (task == null)
				return null;

			if (ReferenceEquals(task, Task<TResult>.Factory))
				return TaskAdapter<TResult>.Factory;

			return new TaskFactoryAdapter<TResult>(task);
		}
	}
}
