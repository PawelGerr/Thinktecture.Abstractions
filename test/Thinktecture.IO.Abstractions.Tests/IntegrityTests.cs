using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using Xunit;

namespace Thinktecture.Abstractions.Tests
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

#if NET5_0
         ExcludeMember<BinaryReader>("Read7BitEncodedInt");
         ExcludeMember<BinaryReader>("Read7BitEncodedInt64");
         ExcludeMember<BinaryWriter>("Write7BitEncodedInt");
         ExcludeMember<BinaryWriter>("Write7BitEncodedInt64");
#endif

         ExcludeMember<Stream>(nameof(Stream.Synchronized));
         ExcludeMember<Stream>(nameof(Stream.BeginRead));
         ExcludeMember<Stream>(nameof(Stream.EndRead));
         ExcludeMember<Stream>(nameof(Stream.BeginWrite));
         ExcludeMember<Stream>(nameof(Stream.EndWrite));

         ExcludeMember<BufferedStream>(nameof(BufferedStream.BeginRead));
         ExcludeMember<BufferedStream>(nameof(BufferedStream.EndRead));
         ExcludeMember<BufferedStream>(nameof(BufferedStream.BeginWrite));
         ExcludeMember<BufferedStream>(nameof(BufferedStream.EndWrite));

         ExcludeMemberCallback = Exclude;
      }

      private bool Exclude(Type type, Type otherType, MemberInfo member)
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
      public void Should_contain_all_adapters()
      {
         CheckAdapters();
      }

      [Fact]
      public void Should_contain_all_adapters_constructors()
      {
         CheckConstructors();
      }

      [Fact]
      public void Should_contain_all_members()
      {
         CheckMembers();
      }
   }
}
