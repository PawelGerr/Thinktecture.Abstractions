using System.Text;
using JetBrains.Annotations;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Encoder"/>.
	/// </summary>
	public class EncoderAdapter : AbstractionAdapter<Encoder>, IEncoder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EncoderAdapter" /> class.
		/// </summary>
		/// <param name="encoder"></param>
		public EncoderAdapter([NotNull] Encoder encoder)
			: base(encoder)
		{
		}

		/// <inheritdoc />
		public void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			Implementation.Convert(chars, charIndex, charCount, bytes, byteIndex, byteCount, flush, out charsUsed, out bytesUsed, out completed);
		}

		/// <inheritdoc />
		public int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return Implementation.GetByteCount(chars, index, count, flush);
		}

		/// <inheritdoc />
		public int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return Implementation.GetBytes(chars, charIndex, charCount, bytes, byteIndex, flush);
		}
	}
}
