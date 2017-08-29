using System;
using System.Net.Sockets;
using JetBrains.Annotations;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Specifies whether a Socket will remain connected after a call to the Close or Close methods and the length of time it will remain connected, if data remains to be sent.
	/// </summary>
	public class LingerOptionAdapter : AbstractionAdapter<LingerOption>, ILingerOption
	{
		/// <inheritdoc />
		public bool Enabled
		{
			get => Implementation.Enabled;
			set => Implementation.Enabled = value;
		}

		/// <inheritdoc />
		public int LingerTime
		{
			get => Implementation.LingerTime;
			set => Implementation.LingerTime = value;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LingerOptionAdapter"/> class.
		/// </summary>
		/// <param name="enable">true to remain connected after the Socket.Close method is called; otherwise, false.</param>
		/// <param name="seconds">The number of seconds to remain connected after the Socket.Close method is called.</param>
		public LingerOptionAdapter(bool enable, int seconds)
			: this(new LingerOption(enable, seconds))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LingerOptionAdapter"/> class.
		/// </summary>
		/// <param name="options">Options to be used by the adapter.</param>
		public LingerOptionAdapter([NotNull] LingerOption options)
			: base(options)
		{
		}
	}
}
