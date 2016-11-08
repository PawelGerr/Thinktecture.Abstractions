using System;
using System.Text;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Decoder"/>.
	/// </summary>
	public class DecoderAdapter : IDecoder
	{
		private readonly Decoder _decoder;

		/// <summary>
		/// Initializes a new instance of the <see cref="DecoderAdapter" /> class.
		/// </summary>
		/// <param name="decoder">Decoder to be used by the adapter.</param>
		public DecoderAdapter(Decoder decoder)
		{
			if (decoder == null)
				throw new ArgumentNullException(nameof(decoder));

			_decoder = decoder;
		}

		/// <inheritdoc />
		public Decoder ToImplementation()
		{
			return _decoder;
		}

		/// <inheritdoc />
		public void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			_decoder.Convert(bytes, byteIndex, byteCount, chars, charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count)
		{
			return _decoder.GetCharCount(bytes, index, count);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return _decoder.GetCharCount(bytes, index, count, flush);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return _decoder.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return _decoder.GetChars(bytes, byteIndex, byteCount, chars, charIndex, flush);
		}

		/// <inheritdoc />
		public void Reset()
		{
			_decoder.Reset();
		}
	}
}