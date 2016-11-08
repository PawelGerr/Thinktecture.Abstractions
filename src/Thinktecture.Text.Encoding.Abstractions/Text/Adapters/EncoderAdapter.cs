using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Encoder"/>.
	/// </summary>
	public class EncoderAdapter : IEncoder
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Encoder InternalInstance { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="EncoderAdapter" /> class.
		/// </summary>
		/// <param name="encoder"></param>
		public EncoderAdapter(Encoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException(nameof(encoder));

			InternalInstance = encoder;
		}

		/// <inheritdoc />
		public Encoder ToImplementation()
		{
			return InternalInstance;
		}

		/// <inheritdoc />
		public void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			InternalInstance.Convert(chars, charIndex, charCount, bytes, byteIndex, byteCount, flush, out charsUsed, out bytesUsed, out completed);
		}

		/// <inheritdoc />
		public int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return InternalInstance.GetByteCount(chars, index, count, flush);
		}

		/// <inheritdoc />
		public int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return InternalInstance.GetBytes(chars, charIndex, charCount, bytes, byteIndex, flush);
		}
	}
}