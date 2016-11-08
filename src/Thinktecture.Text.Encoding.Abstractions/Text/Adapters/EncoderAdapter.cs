using System;
using System.Collections.Generic;
using System.Text;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Encoder"/>.
	/// </summary>
	public class EncoderAdapter : IEncoder
	{
		private readonly Encoder _encoder;

		/// <summary>
		/// Initializes a new instance of the <see cref="EncoderAdapter" /> class.
		/// </summary>
		/// <param name="encoder"></param>
		public EncoderAdapter(Encoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException(nameof(encoder));

			_encoder = encoder;
		}

		/// <inheritdoc />
		public Encoder ToImplementation()
		{
			return _encoder;
		}

		/// <inheritdoc />
		public void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			_encoder.Convert(chars, charIndex, charCount, bytes, byteIndex, byteCount, flush, out charsUsed, out bytesUsed, out completed);
		}

		/// <inheritdoc />
		public int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return _encoder.GetByteCount(chars, index, count, flush);
		}

		/// <inheritdoc />
		public int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return _encoder.GetBytes(chars, charIndex, charCount, bytes, byteIndex, flush);
		}
	}
}