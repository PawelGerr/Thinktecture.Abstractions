﻿using System;
using System.IO;
using System.IO.Pipes;
using Microsoft.Win32.SafeHandles;
using Xunit;

namespace Thinktecture.Abstractions.Tests
{
	public class IntegrityTests : IntegrityTestsBase
	{
		public IntegrityTests()
			: base("IO.Pipes")
		{
			ExcludedTypes.Add(typeof(PipeStreamImpersonationWorker));
			ExcludedTypes.Add(typeof(SafePipeHandle));

			ExcludeTypeCallback = type => type.FullName == "System.IO.Pipes.PipeAccessRule"
													|| type.FullName == "System.IO.Pipes.PipeAuditRule"
													|| type.FullName == "System.IO.Pipes.PipesAclExtensions"
													|| type.FullName == "System.IO.Pipes.PipeSecurity"
													|| type.FullName == "System.IO.Pipes.AnonymousPipeServerStreamAcl"
													|| type.FullName == "System.IO.Pipes.NamedPipeServerStreamAcl";

			ExcludeMembers<PipeStream>(nameof(PipeStream.BeginRead));
			ExcludeMembers<PipeStream>(nameof(PipeStream.EndRead));
			ExcludeMembers<PipeStream>(nameof(PipeStream.BeginWrite));
			ExcludeMembers<PipeStream>(nameof(PipeStream.EndWrite));

			ExcludeMembers<NamedPipeServerStream>(nameof(NamedPipeServerStream.BeginWaitForConnection));
			ExcludeMembers<NamedPipeServerStream>(nameof(NamedPipeServerStream.EndWaitForConnection));
			ExcludeMembers<NamedPipeServerStream>(nameof(NamedPipeServerStream.MaxAllowedServerInstances));

			ExcludeMembers<Stream>(nameof(Stream.Synchronized));
			ExcludeMembers<Stream>(nameof(Stream.Null));
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
