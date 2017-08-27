using System.Net.Sockets;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Specifies whether a Socket will remain connected after a call to the Close or Close methods and the length of time it will remain connected, if data remains to be sent.
	/// </summary>
	public interface ILingerOption : IAbstraction<LingerOption>
	{
		/// <summary>
		/// Gets or sets a value that indicates whether to linger after the Socket is closed.
		/// </summary>
		bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets the amount of time to remain connected after calling the Socket.Close method if data remains to be sent.
		/// </summary>
		int LingerTime { get; set; }
	}
}
