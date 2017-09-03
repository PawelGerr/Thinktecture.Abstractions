using System.Net;
using FluentAssertions;
using Thinktecture.Net.Adapters;
using Xunit;

namespace Thinktecture.Net.CredentialCacheAdapterTests
{
	public class DefaultNetworkCredentials
	{
		[Fact]
		public void Should_return_wrapper_for_CredentialCacheDefaultNetworkCredentials()
		{
			CredentialCacheAdapter.DefaultNetworkCredentials.UnsafeConvert().Should().Be(CredentialCache.DefaultNetworkCredentials);
		}
	}
}
