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
			return (task == null) ? null : new TaskFactoryAdapter(task);
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
			return (task == null) ? null : new TaskFactoryAdapter<TResult>(task);
		}
	}
}
