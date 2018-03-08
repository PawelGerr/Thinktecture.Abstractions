using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Thinktecture.Text;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("Text.Encoding")
		{
			ExcludedTypes.Add(typeof(DecoderFallback));
			ExcludedTypes.Add(typeof(DecoderFallbackBuffer));
			ExcludedTypes.Add(typeof(DecoderReplacementFallback));
			ExcludedTypes.Add(typeof(DecoderExceptionFallback));
			ExcludedTypes.Add(typeof(EncoderFallback));
			ExcludedTypes.Add(typeof(EncoderFallbackBuffer));
			ExcludedTypes.Add(typeof(EncoderReplacementFallback));
			ExcludedTypes.Add(typeof(EncoderExceptionFallback));

			ExcludedTypes.Add(typeof(EncodingProvider));

			CustomTypeMappings.Add(typeof(Encoding), new List<Type> { typeof(IEncoding), typeof(IEncodingGlobals) });

			ExcludeMemberCallback = ExcludeMember;
		}

		private bool ExcludeMember(Type type, Type otherType, MemberInfo member)
		{
			if (otherType == typeof(IEncoding))
			{
				if (member.Name == nameof(Encoding.GetByteCount) || member.Name == nameof(Encoding.GetBytes))
				{
					var parameters = ((MethodInfo)member).GetParameters();
					return parameters.Length == 3 && parameters.First().ParameterType == typeof(string); // in netcoreapp only
				}

				return member is MethodInfo methodInfo && methodInfo.IsStatic ||
				       member is PropertyInfo propInfo && propInfo.GetMethod.IsStatic ||
				       member is FieldInfo fieldInfo && fieldInfo.IsStatic;
			}

			if (otherType == typeof(IEncodingGlobals))
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
