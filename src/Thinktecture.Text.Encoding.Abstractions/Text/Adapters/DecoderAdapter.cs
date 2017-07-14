using System;
using System.ComponentModel;
using System.Text;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Decoder"/>.
	/// </summary>
	public class DecoderAdapter : AbstractionAdapter, IDecoder
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Decoder UnsafeConvert()
		{
			return _instance;
		}

		private readonly Decoder _instance;

		/// <summary>
		/// Initializes a new instance of the <see cref="DecoderAdapter" /> class.
		/// </summary>
		/// <param name="decoder">Decoder to be used by the adapter.</param>
		public DecoderAdapter(Decoder decoder)
			: base(decoder)
		{
			_instance = decoder ?? throw new ArgumentNullException(nameof(decoder));
		}

		/// <inheritdoc />
		public void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			_instance.Convert(bytes, byteIndex, byteCount, chars, charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count)
		{
			return _instance.GetCharCount(bytes, index, count);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return _instance.GetCharCount(bytes, index, count, flush);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return _instance.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return _instance.GetChars(bytes, byteIndex, byteCount, chars, charIndex, flush);
		}

		/// <inheritdoc />
		public void Reset()
		{
			_instance.Reset();
		}
	}
}