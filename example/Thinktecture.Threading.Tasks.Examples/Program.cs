using System;
using System.Threading.Tasks;
using Thinktecture.Threading.Tasks.Adapters;

namespace Thinktecture.Threading.Tasks.Examples
{
	// ReSharper disable once ArrangeTypeModifiers
	public static class Program
	{
		// ReSharper disable once UnusedParameter.Local
		public static async Task Main(string[] args)
		{
			await DoAsync();

			Console.WriteLine("END");
			Console.ReadLine();
		}

		private static async ITask DoAsync()
		{
			var taskGlobals = new TaskGlobals();
			await UseTaskGlobalsAsync(taskGlobals);

			await UseITaskAsync();
			await UseGenericITaskAsync();
		}

		private static async Task UseTaskGlobalsAsync(ITaskGlobals tasks)
		{
			await tasks.Run(() => Console.WriteLine("TaskGlobals.Run()"));
		}

		private static async ITask UseITaskAsync()
		{
			ITask task = TaskAdapter.Factory.StartNew(() => Console.WriteLine("ITask"));

			await task;
		}

		private static async ITask<int> UseGenericITaskAsync()
		{
			ITask<int> task = TaskAdapter<int>.Factory.StartNew(() => 43);

			var result = await task.ConfigureAwait(false);
			Console.WriteLine($"ITask<int> returned {result}");

			return result;
		}
	}
}
