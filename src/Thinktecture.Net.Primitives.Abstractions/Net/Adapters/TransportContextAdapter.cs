#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45 || NET46

using System;
using System.ComponentModel;
using System.Net;
#if NETSTANDARD1_3 || NET45 || NET46
using System.Security.Authentication.ExtendedProtection;
using Thinktecture.Security.Authentication.ExtendedProtection;

#endif

namespace Thinktecture.Net.Adapters
{
	/// <summary>The <see cref="TransportContextAdapter" /> class provides additional context about the underlying transport layer.</summary>
	public class TransportContextAdapter : AbstractionAdapter, ITransportContext
	{
		private readonly TransportContext _context;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new TransportContext UnsafeConvert()
		{
			return _context;
		}

#if NETSTANDARD1_3 || NET45 || NET46

		/// <inheritdoc />
		public IChannelBinding GetChannelBinding(ChannelBindingKind kind)
		{
			return _context.GetChannelBinding(kind).ToInterface();
		}

#endif

		/// <summary>
		/// Initializes new instance of <see cref="TransportContextAdapter"/>.
		/// </summary>
		/// <param name="context"></param>
		public TransportContextAdapter(TransportContext context)
			: base(context)
		{
			if (context == null)
				throw new ArgumentNullException(nameof(context));

			_context = context;
		}
	}
}

#endif