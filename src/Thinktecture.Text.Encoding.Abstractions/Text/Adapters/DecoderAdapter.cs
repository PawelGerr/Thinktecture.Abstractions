using System.Text;
using JetBrains.Annotations;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Decoder"/>.
	/// </summary>
	public class DecoderAdapter : AbstractionAdapter<Decoder>, IDecoder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DecoderAdapter" /> class.
		/// </summary>
		/// <param name="decoder">Decoder to be used by the adapter.</param>
		public DecoderAdapter([NotNull] Decoder decoder)
			: base(decoder)
		{
		}

		/// <inheritdoc />
		public void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			Implementation.Convert(bytes, byteIndex, byteCount, chars, charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count)
		{
			return Implementation.GetCharCount(bytes, index, count);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return Implementation.GetCharCount(bytes, index, count, flush);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return Implementation.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return Implementation.GetChars(bytes, byteIndex, byteCount, chars, charIndex, flush);
		}

		/// <inheritdoc />
		public void Reset()
		{
			Implementation.Reset();
		}
	}
}
