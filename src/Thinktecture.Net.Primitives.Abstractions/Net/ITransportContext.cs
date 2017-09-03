#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45

using System.Net;
using Thinktecture.Net.Adapters;

#if NETSTANDARD1_3 || NET45
using JetBrains.Annotations;
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Security.Authentication.ExtendedProtection;

#endif

namespace Thinktecture.Net
{
	/// <summary>The <see cref="TransportContextAdapter" /> class provides additional context about the underlying transport layer.</summary>
	public interface ITransportContext : IAbstraction<TransportContext>
	{
#if NETSTANDARD1_3 || NET45
		/// <summary>Retrieves the requested channel binding. </summary>
		/// <returns>The requested <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBinding" />, or null if the channel binding is not supported by the current transport or by the operating system.</returns>
		/// <param name="kind">The type of channel binding to retrieve.</param>
		/// <exception cref="T:System.NotSupportedException">
		/// <paramref name="kind" /> is must be <see cref="F:System.Security.Authentication.ExtendedProtection.ChannelBindingKind.Endpoint" /> for use with the <see cref="T:System.Net.TransportContext" /> retrieved from the <see cref="P:System.Net.HttpListenerRequest.TransportContext" /> property.</exception>
		[CanBeNull]
		IChannelBinding GetChannelBinding(ChannelBindingKind kind);
#endif
	}
}

#endif
