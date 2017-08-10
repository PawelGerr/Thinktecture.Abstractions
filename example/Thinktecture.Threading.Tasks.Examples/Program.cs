using System;
using System.Threading.Tasks;
using Thinktecture.Threading.Tasks.Adapters;

namespace Thinktecture.Threading.Tasks.Examples
{
	class Program
	{
		static void Main(string[] args)
		{
			Do().Wait();

			Console.WriteLine("END");
			Console.ReadLine();
		}

		private static async Task Do()
		{
			await GetTaskAdapter();
			await GetGenericTaskAdapter();
			await GetITask();
			await GetGenericITask();
		}

		private static async TaskAdapter GetTaskAdapter()
		{
			var taskAdapter = new TaskAdapter(() => Console.WriteLine("TaskAdapter"));
			taskAdapter.Start();
			await taskAdapter;
		}

		public static async TaskAdapter<int> GetGenericTaskAdapter()
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

		private static async ITask GetITask()
		{
			ITask task = new TaskAdapter(() => Console.WriteLine("ITask"));
			task.Start();
			await task;
		}


		public static async ITask<int> GetGenericITask()
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