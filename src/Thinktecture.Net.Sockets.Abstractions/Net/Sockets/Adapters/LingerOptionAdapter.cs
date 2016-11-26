using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace Thinktecture.Net.Sockets.Adapters
{
	/// <summary>
	/// Specifies whether a Socket will remain connected after a call to the Close or Close methods and the length of time it will remain connected, if data remains to be sent.
	/// </summary>
	public class LingerOptionAdapter : ILingerOption
	{
		private readonly LingerOption _options;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LingerOption UnsafeConvert()
		{
			return _options;
		}

		/// <inheritdoc />
		public bool Enabled
		{
			get { return _options.Enabled; }
			set { _options.Enabled = value; }
		}

		/// <inheritdoc />
		public int LingerTime
		{
			get { return _options.LingerTime; }
			set { _options.LingerTime = value; }
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
		public LingerOptionAdapter(LingerOption options)
		{
			if (options == null)
				throw new ArgumentNullException(nameof(options));

			_options = options;
		}
	}
}