using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

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
		public static ISendPacketsElement ToInterface(this SendPacketsElement element)
		{
			return (element == null) ? null : new SendPacketsElementAdapter(element);
		}

		/// <summary>
		/// Converts provided element to <see cref="SendPacketsElement"/>.
		/// </summary>
		/// <param name="element">Element to convert.</param>
		/// <returns>Converted element.</returns>
		public static SendPacketsElement ToImplementation(this ISendPacketsElement element)
		{
			return element?.UnsafeConvert();
		}
	}
}