using System;
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

#if NETCOREAPP2_1
		/// <inheritdoc />
		public int GetCharCount(ReadOnlySpan<byte> bytes, bool flush)
		{
			return Implementation.GetCharCount(bytes, flush);
		}

		/// <inheritdoc />
		public int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush)
		{
			return Implementation.GetChars(bytes, chars, flush);
		}

		/// <inheritdoc />
		public void Convert(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			Implementation.Convert(bytes, chars, flush, out bytesUsed, out charsUsed, out completed);
		}

#endif

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

#if NET45 || NETSTANDARD2_0
		/// <inheritdoc />
		public unsafe int GetCharCount(byte* bytes, int count, bool flush)
		{
			return Implementation.GetCharCount(bytes, count, flush);
		}

		/// <inheritdoc />
		public unsafe int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			return Implementation.GetChars(bytes, byteCount, chars, charCount, flush);
		}

		/// <inheritdoc />
		public unsafe void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			Implementation.Convert(bytes, byteCount, chars, charCount, flush, out bytesUsed, out charsUsed, out completed);
		}

		/// <inheritdoc />
		public DecoderFallback Fallback
		{
			get => Implementation.Fallback;
			set => Implementation.Fallback = value;
		}

		/// <inheritdoc />
		public DecoderFallbackBuffer FallbackBuffer => Implementation.FallbackBuffer;
#endif
	}
}
