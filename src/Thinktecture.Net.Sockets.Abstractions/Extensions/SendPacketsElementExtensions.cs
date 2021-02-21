using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="SendPacketsElement"/>.
	/// </summary>
	public static class SendPacketsElementExtensions
	{
		/// <summary>
		/// Converts provided element to <see cref="ISendPacketsElement"/>.
		/// </summary>
		/// <param name="element">Element to convert.</param>
		/// <returns>Converted element.</returns>
      [return: NotNullIfNotNull("element")]
		public static ISendPacketsElement? ToInterface(this SendPacketsElement? element)
		{
			return (element == null) ? null : new SendPacketsElementAdapter(element);
		}
	}
}
