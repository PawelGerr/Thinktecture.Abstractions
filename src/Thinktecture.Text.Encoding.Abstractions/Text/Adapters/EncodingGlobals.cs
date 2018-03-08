using System.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Text.Adapters
{
	/// <summary>
	/// Static members of <see cref="Encoding"/>.
	/// </summary>
	public class EncodingGlobals : IEncodingGlobals
	{
		/// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary>
		/// <returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns>
		public IEncoding BigEndianUnicode { get; } = Encoding.BigEndianUnicode.ToInterface();

		/// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary>
		/// <returns>An encoding for the UTF-16 format using the little endian byte order.</returns>
		public IEncoding Unicode { get; } = Encoding.Unicode.ToInterface();

		/// <summary>Gets an encoding for the UTF-8 format.</summary>
		/// <returns>An encoding for the UTF-8 format.</returns>
		// ReSharper disable once InconsistentNaming
		public IEncoding UTF8 { get; } = Encoding.UTF8.ToInterface();

		/// <summary>Converts an entire byte array from one encoding to another.</summary>
		/// <returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
		/// <param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param>
		/// <param name="dstEncoding">The target encoding format. </param>
		/// <param name="bytes">The bytes to convert. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
		/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
		/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
		public byte[] Convert(IEncoding srcEncoding, IEncoding dstEncoding, byte[] bytes)
		{
			return Encoding.Convert(srcEncoding.ToImplementation(), dstEncoding.ToImplementation(), bytes);
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
		public byte[] Convert(IEncoding srcEncoding, Encoding dstEncoding, byte[] bytes)
		{
			return Encoding.Convert(srcEncoding.ToImplementation(), dstEncoding, bytes);
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
		public byte[] Convert(Encoding srcEncoding, IEncoding dstEncoding, byte[] bytes)
		{
			return Encoding.Convert(srcEncoding, dstEncoding.ToImplementation(), bytes);
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
		public byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes)
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
		public byte[] Convert(IEncoding srcEncoding, IEncoding dstEncoding, byte[] bytes, int index, int count)
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
		public byte[] Convert(IEncoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
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
		public byte[] Convert(Encoding srcEncoding, IEncoding dstEncoding, byte[] bytes, int index, int count)
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
		public byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
		{
			return Encoding.Convert(srcEncoding, dstEncoding, bytes, index, count);
		}

		/// <summary>Returns the encoding associated with the specified code page name.</summary>
		/// <returns>The encoding  associated with the specified code page.</returns>
		/// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
		/// <exception cref="T:System.ArgumentException">
		/// <paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception>
		public IEncoding GetEncoding(string name)
		{
			return Encoding.GetEncoding(name).ToInterface();
		}

#if NET45 || NETSTANDARD1_3 || NETSTANDARD2_0
		/// <inheritdoc />
		public IEncoding GetEncoding(int codepage)
		{
			return Encoding.GetEncoding(codepage).ToInterface();
		}

		/// <inheritdoc />
		public IEncoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			return Encoding.GetEncoding(codepage, encoderFallback, decoderFallback).ToInterface();
		}

		/// <inheritdoc />
		public IEncoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			return Encoding.GetEncoding(name, encoderFallback, decoderFallback).ToInterface();
		}
#endif

#if NET45 || NETSTANDARD2_0
		/// <inheritdoc />
		public EncodingInfo[] GetEncodings()
		{
			return Encoding.GetEncodings();
		}

		/// <inheritdoc />
		public IEncoding Default => Encoding.Default.ToInterface();

		/// <inheritdoc />
		public IEncoding ASCII { get; } = Encoding.ASCII.ToInterface();

		/// <inheritdoc />
		public IEncoding UTF7 { get; } = Encoding.UTF7.ToInterface();

		/// <inheritdoc />
		public IEncoding UTF32 { get; } = Encoding.UTF32.ToInterface();
#endif

#if NETSTANDARD1_3 || NETSTANDARD2_0
		/// <inheritdoc />
		public void RegisterProvider(EncodingProvider provider)
		{
			Encoding.RegisterProvider(provider);
		}
#endif
	}
}
