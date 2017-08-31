using System;
using System.Threading.Tasks;
using Thinktecture.Threading.Tasks.Adapters;

namespace Thinktecture.Threading.Tasks.Examples
{
	// ReSharper disable once ArrangeTypeModifiers
	public class Program
	{
		// ReSharper disable once UnusedParameter.Local
		public static void Main(string[] args)
		{
			DoAsync().Wait();

			Console.WriteLine("END");
			Console.ReadLine();
		}

		private static async Task DoAsync()
		{
			await GetTaskAdapterAsync();
			await GetGenericTaskAdapterAsync();
			await GetITaskAsync();
			await GetGenericITaskAsync();
		}

		private static async TaskAdapter GetTaskAdapterAsync()
		{
			var taskAdapter = new TaskAdapter(() => Console.WriteLine("TaskAdapter"));
			taskAdapter.Start();
			await taskAdapter;
		}

		public static async TaskAdapter<int> GetGenericTaskAdapterAsync()
		{
			var taskAdapter = new TaskAdapter<int>(() =>
			{
				Console.WriteLine("TaskAdapter<int>");
				return 42;
			});
			taskAdapter.Start();
			var result = await taskAdapter;
			Console.WriteLine($"TaskAdapter<int> returned {result}");

			return result;
		}

		private static async ITask GetITaskAsync()
		{
			ITask task = new TaskAdapter(() => Console.WriteLine("ITask"));
			task.Start();
			await task;
		}

		public static async ITask<int> GetGenericITaskAsync()
		{
			ITask<int> task = new TaskAdapter<int>(() =>
			{
				Console.WriteLine("ITask<int>");
				return 43;
			});
			task.Start();
			var result = await task;
			Console.WriteLine($"ITask<int> returned {result}");

			return result;
		}
	}
}
