using System;
using System.ComponentModel;
using System.Text;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Decoder"/>.
	/// </summary>
	public class DecoderAdapter : IDecoder
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Decoder InternalInstance { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DecoderAdapter" /> class.
		/// </summary>
		/// <param name="decoder">Decoder to be used by the adapter.</param>
		public DecoderAdapter(Decoder decoder)
		{
			if (decoder == null)
				throw new ArgumentNullException(nameof(decoder));

			InternalInstance = decoder;
		}

		/// <inheritdoc />
		public Decoder ToImplementation()
		{
			return InternalInstance;
		}

		/// <inheritdoc />
		public void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			InternalInstance.Convert(bytes, byteIndex, byteCount, chars, charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count)
		{
			return InternalInstance.GetCharCount(bytes, index, count);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return InternalInstance.GetCharCount(bytes, index, count, flush);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return InternalInstance.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return InternalInstance.GetChars(bytes, byteIndex, byteCount, chars, charIndex, flush);
		}

		/// <inheritdoc />
		public void Reset()
		{
			InternalInstance.Reset();
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return InternalInstance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return InternalInstance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return InternalInstance.GetHashCode();
		}
	}
}