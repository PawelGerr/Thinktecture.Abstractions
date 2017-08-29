using System.Net.Sockets;
using JetBrains.Annotations;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static ISocketAsyncEventArgs ToInterface([CanBeNull] this SocketAsyncEventArgs args)
		{
			return (args == null) ? null : new SocketAsyncEventArgsAdapter(args);
		}

		/// <summary>
		/// Converts provided <see cref="ISocketAsyncEventArgs"/> info to <see cref="SocketAsyncEventArgs"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="ISocketAsyncEventArgs"/> to convert.</param>
		/// <returns>An instance of <see cref="SocketAsyncEventArgs"/>.</returns>
		[CanBeNull]
		public static SocketAsyncEventArgs ToImplementation([CanBeNull] this ISocketAsyncEventArgs abstraction)
		{
			return ((IAbstraction<SocketAsyncEventArgs>)abstraction)?.UnsafeConvert();
		}
	}
}
