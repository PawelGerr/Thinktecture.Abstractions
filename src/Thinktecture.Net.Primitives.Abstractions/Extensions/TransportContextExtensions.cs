using System.Diagnostics.CodeAnalysis;
using System.Net;
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
      [return: NotNullIfNotNull("context")]
		public static ITransportContext? ToInterface(this TransportContext? context)
		{
			return context == null ? null : new TransportContextAdapter(context);
		}
	}
}
