using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="SocketAsyncEventArgs"/>.
	/// </summary>
	public static class SocketAsyncEventArgsExtensions
	{
		/// <summary>
		/// Converts provided event args to <see cref="ISocketAsyncEventArgs"/>.
		/// </summary>
		/// <param name="args">Event args to convert.</param>
		/// <returns>Converted event args.</returns>
		public static ISocketAsyncEventArgs ToInterface(this SocketAsyncEventArgs args)
		{
			return (args == null) ? null : new SocketAsyncEventArgsAdapter(args);
		}

		/// <summary>
		/// Converts provided event args to <see cref="SocketAsyncEventArgs"/>.
		/// </summary>
		/// <param name="args">Event args to convert.</param>
		/// <returns>Converted event args.</returns>
		public static SocketAsyncEventArgs ToImplementation(this ISocketAsyncEventArgs args)
		{
			return args?.UnsafeConvert();
		}
	}
}