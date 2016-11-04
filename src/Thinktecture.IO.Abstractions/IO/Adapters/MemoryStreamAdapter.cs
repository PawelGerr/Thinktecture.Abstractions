using System;
using System.IO;

namespace Thinktecture.IO.Adapters
{
	public class MemoryStreamAdapter : StreamAdapter, IMemoryStream
	{
		private readonly MemoryStream _stream;

		/// <inheritdoc />
		public int Capacity
		{
			get { return _stream.Capacity; }
			set { _stream.Capacity = value; }
		}

		public MemoryStreamAdapter(MemoryStream stream)
			: base(stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			_stream = stream;
		}

		/// <inheritdoc />
		MemoryStream IMemoryStream.ToImplementation()
		{
			return _stream;
		}

		/// <inheritdoc />
		public byte[] ToArray()
		{
			return _stream.ToArray();
		}

		/// <inheritdoc />
		public void WriteTo(IStream stream)
		{
			_stream.WriteTo(stream.ToImplementation());
		}
	}
}