#if NETSTANDARD1_1 || NETSTANDARD1_3 || NET45

using System.Net;
using JetBrains.Annotations;
using Thinktecture.Net;
using Thinktecture.Net.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="TransportContext"/>.
	/// </summary>
	public static class TransportContextExtensions
	{
		/// <summary>
		/// Converts provided context to <see cref="ITransportContext"/>.
		/// </summary>
		/// <param name="context">Context to convert.</param>
		/// <returns>Converted context.</returns>
		[CanBeNull]
		public static ITransportContext ToInterface([CanBeNull] this TransportContext context)
		{
			return (context == null) ? null : new TransportContextAdapter(context);
		}
	}
}

#endif
