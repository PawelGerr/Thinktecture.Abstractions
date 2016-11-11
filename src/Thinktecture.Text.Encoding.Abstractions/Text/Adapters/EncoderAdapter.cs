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
		public Encoder UnsafeConvert()
		{
			return _instance;
		}

		private readonly Encoder _instance;

		/// <summary>
		/// Initializes a new instance of the <see cref="EncoderAdapter" /> class.
		/// </summary>
		/// <param name="encoder"></param>
		public EncoderAdapter(Encoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException(nameof(encoder));

			_instance = encoder;
		}

		/// <inheritdoc />
		public Encoder ToImplementation()
		{
			return _instance;
		}

		/// <inheritdoc />
		public void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			_instance.Convert(chars, charIndex, charCount, bytes, byteIndex, byteCount, flush, out charsUsed, out bytesUsed, out completed);
		}

		/// <inheritdoc />
		public int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return _instance.GetByteCount(chars, index, count, flush);
		}

		/// <inheritdoc />
		public int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return _instance.GetBytes(chars, charIndex, charCount, bytes, byteIndex, flush);
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return _instance.ToString();
		}

		/// <inheritdoc />
		public override bool Equals(object obj)
		{
			return _instance.Equals(obj);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return _instance.GetHashCode();
		}
	}
}