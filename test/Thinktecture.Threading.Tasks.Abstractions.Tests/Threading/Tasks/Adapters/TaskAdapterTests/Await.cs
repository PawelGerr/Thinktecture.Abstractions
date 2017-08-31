using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Thinktecture.Threading.Tasks.Adapters.TaskAdapterTests
{
	public class Await
	{
		[Fact]
		public async Task Should_wait_for_taskadapter()
		{
			var executed = false;
			var t = new TaskAdapter(() => executed = true);
			t.Start();

			await t;

			executed.Should().BeTrue();
		}

		[Fact]
		public async Task Should_wait_for_itask()
		{
			var executed = false;
			ITask t = new TaskAdapter(() => executed = true);
			t.Start();

			await t;

			executed.Should().BeTrue();
		}

		[Fact]
		public async Task Should_wait_for_result_of_taskadapter()
		{
			var t = new TaskAdapter<int>(() => 42);
			t.Start();

			(await t).Should().Be(42);
		}

		[Fact]
		public async Task Should_wait_for_result_of_itask()
		{
			ITask<int> t = new TaskAdapter<int>(() => 42);
			t.Start();

			(await t).Should().Be(42);
		}

		[Fact]
		public async Task Should_wait_for_continuation_task()
		{
			ITask<int> t = new TaskAdapter<int>(() => 42);
			t.Start();
			t = t.ContinueWith(t2 => t2.Result + 1);

			(await t).Should().Be(43);
		}
	}
}
