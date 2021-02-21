using System;
using System.IO;
using System.Text;

namespace Thinktecture.Text
{
   /// <summary>
   /// Static members of <see cref="Encoding"/>.
   /// </summary>
   public interface IEncodingGlobals
   {
      private class EncodingGlobals : IEncodingGlobals
      {
      }

      /// <summary>
      /// Default implementation of <see cref="IEncodingGlobals"/>.
      /// </summary>
      public static readonly IEncodingGlobals Instance = new EncodingGlobals();

      /// <summary>Gets an encoding for the UTF-16 format that uses the big endian byte order.</summary>
      /// <returns>An encoding object for the UTF-16 format that uses the big endian byte order.</returns>
      IEncoding BigEndianUnicode => Encoding.BigEndianUnicode.ToInterface();

      /// <summary>Gets an encoding for the UTF-16 format using the little endian byte order.</summary>
      /// <returns>An encoding for the UTF-16 format using the little endian byte order.</returns>
      IEncoding Unicode => Encoding.Unicode.ToInterface();

      /// <summary>Gets an encoding for the UTF-8 format.</summary>
      /// <returns>An encoding for the UTF-8 format.</returns>
      // ReSharper disable once InconsistentNaming
      IEncoding UTF8 => Encoding.UTF8.ToInterface();

      /// <summary>Gets an encoding for the operating system's current ANSI code page.</summary>
      /// <returns>An encoding for the operating system's current ANSI code page.</returns>
      /// <filterpriority>1</filterpriority>
      IEncoding Default => Encoding.Default.ToInterface();

      /// <summary>Gets an encoding for the ASCII (7-bit) character set.</summary>
      /// <returns>An  encoding for the ASCII (7-bit) character set.</returns>
      /// <filterpriority>1</filterpriority>
      // ReSharper disable once InconsistentNaming
      IEncoding ASCII => Encoding.ASCII.ToInterface();

#if NET5_0
      /// <summary>Gets an encoding for the Latin1 character set (ISO-8859-1).</summary>
      IEncoding Latin1 => Encoding.Latin1.ToInterface();
#endif

      /// <summary>Gets an encoding for the UTF-7 format.</summary>
      /// <returns>An encoding for the UTF-7 format.</returns>
      /// <filterpriority>1</filterpriority>
      // ReSharper disable once InconsistentNaming
      [Obsolete("The UTF-7 encoding is insecure and should not be used. Consider using UTF-8 instead.")]
      IEncoding UTF7 => Encoding.UTF7.ToInterface();

      /// <summary>Gets an encoding for the UTF-32 format using the little endian byte order.</summary>
      /// <returns>An  encoding object for the UTF-32 format using the little endian byte order.</returns>
      /// <filterpriority>1</filterpriority>
      // ReSharper disable once InconsistentNaming
      IEncoding UTF32 => Encoding.UTF32.ToInterface();

      /// <summary>Converts an entire byte array from one encoding to another.</summary>
      /// <returns>An array of type <see cref="T:System.Byte" /> containing the results of converting <paramref name="bytes" /> from <paramref name="srcEncoding" /> to <paramref name="dstEncoding" />.</returns>
      /// <param name="srcEncoding">The encoding format of <paramref name="bytes" />. </param>
      /// <param name="dstEncoding">The target encoding format. </param>
      /// <param name="bytes">The bytes to convert. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="srcEncoding" /> is null.-or- <paramref name="dstEncoding" /> is null.-or- <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-srcEncoding.<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-dstEncoding.<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      byte[] Convert(IEncoding srcEncoding, IEncoding dstEncoding, byte[] bytes)
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
      byte[] Convert(IEncoding srcEncoding, Encoding dstEncoding, byte[] bytes)
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
      byte[] Convert(Encoding srcEncoding, IEncoding dstEncoding, byte[] bytes)
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
      byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes)
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
      byte[] Convert(IEncoding srcEncoding, IEncoding dstEncoding, byte[] bytes, int index, int count)
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
      byte[] Convert(IEncoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
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
      byte[] Convert(Encoding srcEncoding, IEncoding dstEncoding, byte[] bytes, int index, int count)
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
      byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count)
      {
         return Encoding.Convert(srcEncoding, dstEncoding, bytes, index, count);
      }

#if NET5_0
      /// <summary>Creates a <see cref="T:System.IO.Stream" /> that serves to transcode data between an inner <see cref="T:System.Text.Encoding" /> and an outer <see cref="T:System.Text.Encoding" />, similar to <see cref="M:System.Text.Encoding.Convert(System.Text.Encoding,System.Text.Encoding,System.Byte[])" />.</summary>
      /// <param name="innerStream">The stream to wrap.</param>
      /// <param name="innerStreamEncoding">The encoding associated with <paramref name="innerStream" />.</param>
      /// <param name="outerStreamEncoding">The encoding associated with the <see cref="T:System.IO.Stream" /> that's returned by this method.</param>
      /// <param name="leaveOpen">
      /// <see langword="true" /> if disposing the <see cref="T:System.IO.Stream" /> returned by this method should <em>not</em> dispose <paramref name="innerStream" />.</param>
      /// <returns>A stream that transcodes the contents of <paramref name="innerStream" /> as <paramref name="outerStreamEncoding" />.</returns>
      Stream CreateTranscodingStream(
         Stream innerStream,
         IEncoding innerStreamEncoding,
         IEncoding outerStreamEncoding,
         bool leaveOpen = false)
      {
         return Encoding.CreateTranscodingStream(innerStream, innerStreamEncoding.ToImplementation(), outerStreamEncoding.ToImplementation(), leaveOpen);
      }
#endif

      /// <summary>Returns the encoding associated with the specified code page name.</summary>
      /// <returns>The encoding  associated with the specified code page.</returns>
      /// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception>
      IEncoding GetEncoding(string name)
      {
         return Encoding.GetEncoding(name).ToInterface();
      }

      /// <summary>Returns the encoding associated with the specified code page identifier.</summary>
      /// <returns>The encoding that is associated with the specified code page.</returns>
      /// <param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.-or- 0 (zero), to use the default encoding. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="codepage" /> is less than zero or greater than 65535. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="codepage" /> is not supported by the underlying platform. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="codepage" /> is not supported by the underlying platform. </exception>
      /// <filterpriority>1</filterpriority>
      IEncoding GetEncoding(int codepage)
      {
         return Encoding.GetEncoding(codepage).ToInterface();
      }

      /// <summary>Returns the encoding associated with the specified code page identifier. Parameters specify an error handler for characters that cannot be encoded and byte sequences that cannot be decoded.</summary>
      /// <returns>The encoding that is associated with the specified code page.</returns>
      /// <param name="codepage">The code page identifier of the preferred encoding. Possible values are listed in the Code Page column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.-or- 0 (zero), to use the default encoding. </param>
      /// <param name="encoderFallback">An object that provides an error-handling procedure when a character cannot be encoded with the current encoding. </param>
      /// <param name="decoderFallback">An object that provides an error-handling procedure when a byte sequence cannot be decoded with the current encoding. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="codepage" /> is less than zero or greater than 65535. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="codepage" /> is not supported by the underlying platform. </exception>
      /// <exception cref="T:System.NotSupportedException">
      /// <paramref name="codepage" /> is not supported by the underlying platform. </exception>
      /// <filterpriority>1</filterpriority>
      IEncoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
      {
         return Encoding.GetEncoding(codepage, encoderFallback, decoderFallback).ToInterface();
      }

      /// <summary>Returns the encoding associated with the specified code page name. Parameters specify an error handler for characters that cannot be encoded and byte sequences that cannot be decoded.</summary>
      /// <returns>The encoding that is associated with the specified code page.</returns>
      /// <param name="name">The code page name of the preferred encoding. Any value returned by the <see cref="P:System.Text.Encoding.WebName" /> property is valid. Possible values are listed in the Name column of the table that appears in the <see cref="T:System.Text.Encoding" /> class topic.</param>
      /// <param name="encoderFallback">An object that provides an error-handling procedure when a character cannot be encoded with the current encoding. </param>
      /// <param name="decoderFallback">An object that provides an error-handling procedure when a byte sequence cannot be decoded with the current encoding. </param>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="name" /> is not a valid code page name.-or- The code page indicated by <paramref name="name" /> is not supported by the underlying platform. </exception>
      /// <filterpriority>1</filterpriority>
      IEncoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
      {
         return Encoding.GetEncoding(name, encoderFallback, decoderFallback).ToInterface();
      }

      /// <summary>Returns an array that contains all encodings.</summary>
      /// <returns>An array that contains all encodings.</returns>
      /// <filterpriority>1</filterpriority>
      EncodingInfo[] GetEncodings()
      {
         return Encoding.GetEncodings();
      }

      /// <summary>Registers an encoding provider. </summary>
      /// <param name="provider">A subclass of <see cref="T:System.Text.EncodingProvider" /> that provides access to additional character encodings. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="provider" /> is null. </exception>
      void RegisterProvider(EncodingProvider provider)
      {
         Encoding.RegisterProvider(provider);
      }
   }
}
