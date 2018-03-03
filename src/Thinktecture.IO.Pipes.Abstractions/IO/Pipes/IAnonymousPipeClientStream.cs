using System.IO.Pipes;

namespace Thinktecture.IO.Pipes
{
	/// <summary>
	/// Exposes the client side of an anonymous pipe stream, which supports both synchronous and asynchronous read and write operations.
	/// </summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IAnonymousPipeClientStream : IPipeStream, IAbstraction<AnonymousPipeClientStream>
	{
	}
}
