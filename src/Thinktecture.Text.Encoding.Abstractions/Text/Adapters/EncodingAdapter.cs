using System;
using System.Text;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Adapter for <see cref="Encoding"/>.
	/// </summary>
	public class EncodingAdapter : AbstractionAdapter<Encoding>, IEncoding
	{
		/// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary>
		/// <returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns>
		[NotNull]
		public static IEncoding BigEndianUnicode => new EncodingAdapter(Encoding.BigEndianUnicode);

		/// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary>
		/// <returns>An encoding for the UTF-16 format using the little endian byte order.</returns>
		[NotNull]
		public static IEncoding Unicode => new EncodingAdapter(Encoding.Unicode);

		/// <summary>Gets an encoding for the UTF-8 format.</summary>
		/// <returns>An encoding for the UTF-8 format.</returns>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		public static IEncoding UTF8 => new EncodingAdapter(Encoding.UTF8);

		/// <summary>Converts an entire byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The target encoding format. </param>
		/// <param name="bytes">The bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes)
		{
			return Convert(srcEncoding.ToImplementation(), dstEncoding.ToImplementation(), bytes);
		}

		/// <summary>Converts an entire byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The target encoding format. </param>
		/// <param name="bytes">The bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes)
		{
			return Convert(srcEncoding.ToImplementation(), dstEncoding, bytes);
		}

		/// <summary>Converts an entire byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The target encoding format. </param>
		/// <param name="bytes">The bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes)
		{
			return Convert(srcEncoding, dstEncoding.ToImplementation(), bytes);
		}

		/// <summary>Converts an entire byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The target encoding format. </param>
		/// <param name="bytes">The bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes)
		{
			return Encoding.Convert(srcEncoding, dstEncoding, bytes);
		}

		/// <summary>Converts a range of bytes in a byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the result of converting a range of bytes in <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding of the source array, <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The encoding of the output array. </param>
		/// <param name="bytes">The array of bytes to convert. </param>
		/// <param name="index">The index of the first element of <paramref name="bytes" /> to convert. </param>
		/// <param name="count">The number of bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the byte array. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes, int index, int count)
		{
			return Encoding.Convert(srcEncoding.ToImplementation(), dstEncoding.ToImplementation(), bytes, index, count);
		}

		/// <summary>Converts a range of bytes in a byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the result of converting a range of bytes in <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding of the source array, <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The encoding of the output array. </param>
		/// <param name="bytes">The array of bytes to convert. </param>
		/// <param name="index">The index of the first element of <paramref name="bytes" /> to convert. </param>
		/// <param name="count">The number of bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the byte array. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes, int index, int count)
		{
			return Encoding.Convert(srcEncoding.ToImplementation(), dstEncoding, bytes, index, count);
		}

		/// <summary>Converts a range of bytes in a byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the result of converting a range of bytes in <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding of the source array, <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The encoding of the output array. </param>
		/// <param name="bytes">The array of bytes to convert. </param>
		/// <param name="index">The index of the first element of <paramref name="bytes" /> to convert. </param>
		/// <param name="count">The number of bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the byte array. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes, int index, int count)
		{
			return Encoding.Convert(srcEncoding, dstEncoding.ToImplementation(), bytes, index, count);
		}

		/// <summary>Converts a range of bytes in a byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the result of converting a range of bytes in <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding of the source array, <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The encoding of the output array. </param>
		/// <param name="bytes">The array of bytes to convert. </param>
		/// <param name="index">The index of the first element of <paramref name="bytes" /> to convert. </param>
		/// <param name="count">The number of bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the byte array. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		[NotNull]
		public static byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes, int index, int count)
		{
			return Encoding.Convert(srcEncoding, dstEncoding, bytes, index, count);
		}

		/// <summary>Returns the encoding associated with the specified code page name.</summary>
		/// <returns>The encoding  associated with the specified code page.</returns>
		/// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception>
		[NotNull]
		public static IEncoding GetEncoding([NotNull] string name)
		{
			return Encoding.GetEncoding(name).ToInterface();
		}

		/// <inheritdoc />
		public string WebName => Implementation.WebName;

		/// <summary>
		/// Initializes a new instance of the <see cref="EncodingAdapter" /> class.
		/// </summary>
		/// <param name="encoding">Encoding to be used by the adapter.</param>
		public EncodingAdapter([NotNull] Encoding encoding)
			: base(encoding)
		{
		}

		/// <inheritdoc />
		public int GetByteCount(char[] chars)
		{
			return Implementation.GetByteCount(chars);
		}

		/// <inheritdoc />
		public int GetByteCount(char[] chars, int index, int count)
		{
			return Implementation.GetByteCount(chars, index, count);
		}

		/// <inheritdoc />
		public int GetByteCount(string s)
		{
			return Implementation.GetByteCount(s);
		}

		/// <inheritdoc />
		public byte[] GetBytes(char[] chars)
		{
			return Implementation.GetBytes(chars);
		}

		/// <inheritdoc />
		public byte[] GetBytes(char[] chars, int index, int count)
		{
			return Implementation.GetBytes(chars, index, count);
		}

		/// <inheritdoc />
		public int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return Implementation.GetBytes(chars, charIndex, charCount, bytes, byteIndex);
		}

		/// <inheritdoc />
		public byte[] GetBytes(string s)
		{
			return Implementation.GetBytes(s);
		}

		/// <inheritdoc />
		public int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return Implementation.GetBytes(s, charIndex, charCount, bytes, byteIndex);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes)
		{
			return Implementation.GetCharCount(bytes);
		}

		/// <inheritdoc />
		public int GetCharCount(byte[] bytes, int index, int count)
		{
			return Implementation.GetCharCount(bytes, index, count);
		}

		/// <inheritdoc />
		public char[] GetChars(byte[] bytes)
		{
			return Implementation.GetChars(bytes);
		}

		/// <inheritdoc />
		public char[] GetChars(byte[] bytes, int index, int count)
		{
			return Implementation.GetChars(bytes, index, count);
		}

		/// <inheritdoc />
		public int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return Implementation.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		/// <inheritdoc />
		public IDecoder GetDecoder()
		{
			return Implementation.GetDecoder().ToInterface();
		}

		/// <inheritdoc />
		public IEncoder GetEncoder()
		{
			return Implementation.GetEncoder().ToInterface();
		}

		/// <inheritdoc />
		public int GetMaxByteCount(int charCount)
		{
			return Implementation.GetMaxByteCount(charCount);
		}

		/// <inheritdoc />
		public int GetMaxCharCount(int byteCount)
		{
			return Implementation.GetMaxCharCount(byteCount);
		}

		/// <inheritdoc />
		public byte[] GetPreamble()
		{
			return Implementation.GetPreamble();
		}

		/// <inheritdoc />
		public string GetString(byte[] bytes, int index, int count)
		{
			return Implementation.GetString(bytes, index, count);
		}
	}
}
