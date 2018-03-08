using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Thinktecture.Runtime.CompilerServices;
using Thinktecture.Threading.Tasks;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("Threading.Tasks")
		{
			ExcludedTypes.Add(typeof(AsyncTaskMethodBuilder));
			ExcludedTypes.Add(typeof(AsyncVoidMethodBuilder));
			ExcludedTypes.Add(typeof(ConfiguredTaskAwaitable));
			ExcludedTypes.Add(typeof(ConfiguredTaskAwaitable<>));
			ExcludedTypes.Add(typeof(TaskAwaiter));
			ExcludedTypes.Add(typeof(TaskAwaiter<>));
			ExcludedTypes.Add(typeof(YieldAwaitable));
			ExcludedTypes.Add(typeof(CancellationToken));
			ExcludedTypes.Add(typeof(CancellationTokenRegistration));
			ExcludedTypes.Add(typeof(CancellationTokenSource));
			ExcludedTypes.Add(typeof(ConcurrentExclusiveSchedulerPair));
			ExcludedTypes.Add(typeof(TaskCompletionSource<>));
			ExcludedTypes.Add(typeof(TaskScheduler));
			ExcludedTypes.Add(typeof(UnobservedTaskExceptionEventArgs));

			ExcludedTypes.Add(typeof(AsyncTaskMethodBuilder<>));
			ExcludedTypes.Add(typeof(IAsyncTaskMethodBuilder<>));
			ExcludedTypes.Add(typeof(IAsyncTaskMethodBuilder<,>));

			CustomTypeMappings.Add(typeof(System.Threading.Tasks.TaskExtensions), typeof(TaskExtensions));
			CustomTypeMappings.Add(typeof(Task), typeof(ITask), typeof(ITaskGlobals));
			CustomTypeMappings.Add(typeof(Task<>), typeof(ITask<>), typeof(ITaskGlobals<>));

			ExcludeMember<Task>(nameof(Task.IsCompletedSuccessfully)); // netcoreapp only

			ExcludeMemberCallback = ExcludeMember;
		}

		private bool ExcludeMember(Type type, Type otherType, MemberInfo member)
		{
			if (otherType == typeof(ITask) || otherType == typeof(ITask<>))
			{
				return member is MethodInfo methodInfo && methodInfo.IsStatic ||
				       member is PropertyInfo propInfo && propInfo.GetMethod.IsStatic ||
				       member is FieldInfo fieldInfo && fieldInfo.IsStatic;
			}

			if (otherType == typeof(ITaskGlobals) || otherType == typeof(ITaskGlobals<>))
			{
				return member is MethodInfo methodInfo && !methodInfo.IsStatic ||
				       member is PropertyInfo propertyInfo && !propertyInfo.GetMethod.IsStatic ||
				       member is FieldInfo fieldInfo && !fieldInfo.IsStatic;
			}

			return false;
		}

		[Fact]
		public void Should_contain_all_types()
		{
			CheckTypes();
		}

		[Fact]
		public void Should_contain_all_members()
		{
			CheckMembers();
		}
	}
}
