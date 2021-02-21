using System.Net;
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Security.Authentication.ExtendedProtection;

namespace Thinktecture.Net.Adapters
{
	/// <summary>The <see cref="TransportContextAdapter" /> class provides additional context about the underlying transport layer.</summary>
	public class TransportContextAdapter : AbstractionAdapter<TransportContext>, ITransportContext
	{
		/// <inheritdoc />
		public IChannelBinding? GetChannelBinding(ChannelBindingKind kind)
		{
			return Implementation.GetChannelBinding(kind).ToInterface();
		}

		/// <summary>
		/// Initializes new instance of <see cref="TransportContextAdapter"/>.
		/// </summary>
		/// <param name="context"></param>
		public TransportContextAdapter(TransportContext context)
			: base(context)
		{
		}
	}
}
