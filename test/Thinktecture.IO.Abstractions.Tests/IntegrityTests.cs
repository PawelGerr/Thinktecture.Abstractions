using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using Xunit;

namespace Thinktecture
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("IO")
		{
			ExcludedTypes.Add(typeof(EndOfStreamException));
			ExcludedTypes.Add(typeof(FileNotFoundException));
			ExcludedTypes.Add(typeof(InvalidDataException));
			ExcludedTypes.Add(typeof(IOException));

			ExcludeMember<IndentedTextWriter>(nameof(IndentedTextWriter.DefaultTabString));
			ExcludeMember<TextWriter>(nameof(TextWriter.Synchronized));
			ExcludeMember<TextReader>(nameof(TextReader.Synchronized));

			ExcludeMember<Stream>(nameof(Stream.Synchronized));
			ExcludeMember<Stream>(nameof(Stream.BeginRead));
			ExcludeMember<Stream>(nameof(Stream.EndRead));
			ExcludeMember<Stream>(nameof(Stream.BeginWrite));
			ExcludeMember<Stream>(nameof(Stream.EndWrite));

			ExcludeMember<BufferedStream>(nameof(BufferedStream.BeginRead));
			ExcludeMember<BufferedStream>(nameof(BufferedStream.EndRead));
			ExcludeMember<BufferedStream>(nameof(BufferedStream.BeginWrite));
			ExcludeMember<BufferedStream>(nameof(BufferedStream.EndWrite));

			ExcludeMember<BufferedStream>(nameof(BufferedStream.UnderlyingStream)); // is public in netcoreapp only (not netstandard)
			ExcludeMember<BufferedStream>(nameof(BufferedStream.BufferSize)); // is public in netcoreapp only (not netstandard)

			ExcludeCallback = Exlude;
		}

		private bool Exlude(Type type, Type otherType, MemberInfo member)
		{
			if (member.Name == "Null")
			{
				return member is FieldInfo fieldInfo && fieldInfo.IsStatic;
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
