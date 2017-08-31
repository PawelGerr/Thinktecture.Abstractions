using System.Threading.Tasks;
using JetBrains.Annotations;
using Thinktecture.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for arrays.
	/// </summary>
	public static class ArrayExtensions
	{
		/// <summary>
		/// Converts an array of <see cref="Task"/> to an array of <see cref="ITask"/>.
		/// </summary>
		/// <param name="tasks">Array to convert.</param>
		/// <returns>An array of <see cref="ITask"/>.</returns>
		[CanBeNull]
		public static ITask[] ToInterface([CanBeNull] this Task[] tasks)
		{
			if (tasks == null)
				return null;

			var abstractions = new ITask[tasks.Length];

			for (var i = 0; i < tasks.Length; i++)
			{
				abstractions[i] = tasks[i].ToInterface();
			}

			return abstractions;
		}

		/// <summary>
		/// Converts an array of <see cref="Task{TResult}"/> to an array of <see cref="ITask{TResult}"/>.
		/// </summary>
		/// <param name="tasks">Array to convert.</param>
		/// <typeparam name="TResult">Type of the result.</typeparam>
		/// <returns>An array of <see cref="ITask{TResult}"/>.</returns>
		[CanBeNull]
		public static ITask<TResult>[] ToInterface<TResult>([CanBeNull] this Task<TResult>[] tasks)
		{
			if (tasks == null)
				return null;

			var abstractions = new ITask<TResult>[tasks.Length];

			for (var i = 0; i < tasks.Length; i++)
			{
				abstractions[i] = tasks[i].ToInterface();
			}

			return abstractions;
		}
	}
}
