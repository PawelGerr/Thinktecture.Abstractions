#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;

#if NETSTANDARD1_3 || NET45
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Security.Authentication.ExtendedProtection;

#endif

namespace Thinktecture.Net.Adapters
{
	/// <summary>The <see cref="TransportContextAdapter" /> class provides additional context about the underlying transport layer.</summary>
	public class TransportContextAdapter : AbstractionAdapter<TransportContext>, ITransportContext
	{
#if NETSTANDARD1_3 || NET45

		/// <inheritdoc />
		public IChannelBinding GetChannelBinding(ChannelBindingKind kind)
		{
			return Implementation.GetChannelBinding(kind).ToInterface();
		}

#endif

		/// <summary>
		/// Initializes new instance of <see cref="TransportContextAdapter"/>.
		/// </summary>
		/// <param name="context"></param>
		public TransportContextAdapter([NotNull] TransportContext context)
			: base(context)
		{
		}
	}
}

#endif
