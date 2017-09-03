using System.Text;
using JetBrains.Annotations;

namespace Thinktecture.Text
{
	/// <summary>
	/// Static members of <see cref="Encoding"/>.
	/// </summary>
	public interface IEncodingGlobals
	{
		/// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary>
		/// <returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns>
		[NotNull]
		IEncoding BigEndianUnicode { get; }

		/// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary>
		/// <returns>An encoding for the UTF-16 format using the little endian byte order.</returns>
		[NotNull]
		IEncoding Unicode { get; }

		/// <summary>Gets an encoding for the UTF-8 format.</summary>
		/// <returns>An encoding for the UTF-8 format.</returns>
		[NotNull]
		// ReSharper disable once InconsistentNaming
		IEncoding UTF8 { get; }

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
		byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes);

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
		byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes);

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
		byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes);

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
		byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes);

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
		byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes, int index, int count);

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
		byte[] Convert([NotNull] IEncoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes, int index, int count);

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
		byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] IEncoding dstEncoding, [NotNull] byte[] bytes, int index, int count);

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
		byte[] Convert([NotNull] Encoding srcEncoding, [NotNull] Encoding dstEncoding, [NotNull] byte[] bytes, int index, int count);

		/// <summary>Returns the encoding associated with the specified code page name.</summary>
		/// <returns>The encoding  associated with the specified code page.</returns>
		/// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception>
		[NotNull]
		IEncoding GetEncoding([NotNull] string name);
	}
}
