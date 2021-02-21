using System;
using System.Text;

namespace Thinktecture.Text
{
   /// <summary>Represents a character encoding.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
   public interface IEncoding : IAbstraction<Encoding>, ICloneable
   {
      /// <summary>When overridden in a derived class, gets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.</summary>
      /// <returns>The IANA name for the current <see cref="T:System.Text.Encoding" />.</returns>
      string WebName { get; }

      /// <summary>
      /// The preamble.
      /// </summary>
      ReadOnlySpan<byte> Preamble { get; }

      /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified string.</summary>
      /// <returns>The number of bytes produced by encoding the specified characters.</returns>
      /// <param name="s">The string to encode. </param>
      /// <param name="index">The index of the first character to encode. </param>
      /// <param name="count">The number of characters to encode. </param>
      int GetByteCount(string s, int index, int count);

      /// <summary>When overridden in a derived class, encodes all the characters in the specified string into a sequence of bytes.</summary>
      /// <param name="s">The string to encode. </param>
      /// <param name="index">The index of the first character to encode. </param>
      /// <param name="count">The number of characters to encode. </param>
      /// <returns>Encoded string.</returns>
      byte[] GetBytes(string s, int index, int count);

      /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding all the characters in the specified span of characters.</summary>
      /// <param name="chars">The span of characters containing the characters to encode.</param>
      /// <returns>The number of bytes produced by encoding all the characters in the specified span of character.</returns>
      int GetByteCount(ReadOnlySpan<char> chars);

      /// <summary>When overridden in a derived class, encodes all the characters in the specified span of character into a sequence of bytes.</summary>
      /// <param name="chars">The character array containing the characters to encode.</param>
      /// <param name="bytes">Span to write into.</param>
      /// <returns>Number of bytes written to <paramref name="bytes"/>.</returns>
      int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes);

      /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding all the bytes in the specified span of bytes.</summary>
      /// <param name="bytes">The span of bytes containing the sequence of bytes to decode. </param>
      /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
      int GetCharCount(ReadOnlySpan<byte> bytes);

      /// <summary>When overridden in a derived class, decodes all the bytes in the specified span of bytes into a set of characters.</summary>
      /// <param name="bytes">The span of bytes containing the sequence of bytes to decode. </param>
      /// <param name="chars">Span to write into.</param>
      /// <returns>Number of characters written into chars.</returns>
      int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars);

      /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified span into a string.</summary>
      /// <param name="bytes">The span containing the sequence of bytes to decode. </param>
      /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
      string GetString(ReadOnlySpan<byte> bytes);

      /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding all the characters in the specified character array.</summary>
      /// <returns>The number of bytes produced by encoding all the characters in the specified character array.</returns>
      /// <param name="chars">The character array containing the characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      int GetByteCount(char[] chars);

      /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
      /// <returns>The number of bytes produced by encoding the specified characters.</returns>
      /// <param name="chars">The character array containing the set of characters to encode. </param>
      /// <param name="index">The index of the first character to encode. </param>
      /// <param name="count">The number of characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      int GetByteCount(char[] chars, int index, int count);

      /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding the characters in the specified string.</summary>
      /// <returns>The number of bytes produced by encoding the specified characters.</returns>
      /// <param name="s">The string containing the set of characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="s" /> is null. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      int GetByteCount(string s);

      /// <summary>When overridden in a derived class, encodes all the characters in the specified character array into a sequence of bytes.</summary>
      /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
      /// <param name="chars">The character array containing the characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      byte[] GetBytes(char[] chars);

      /// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into a sequence of bytes.</summary>
      /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
      /// <param name="chars">The character array containing the set of characters to encode. </param>
      /// <param name="index">The index of the first character to encode. </param>
      /// <param name="count">The number of characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      byte[] GetBytes(char[] chars, int index, int count);

      /// <summary>When overridden in a derived class, encodes a set of characters from the specified character array into the specified byte array.</summary>
      /// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
      /// <param name="chars">The character array containing the set of characters to encode. </param>
      /// <param name="charIndex">The index of the first character to encode. </param>
      /// <param name="charCount">The number of characters to encode. </param>
      /// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
      /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null.-or- <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

      /// <summary>When overridden in a derived class, encodes all the characters in the specified string into a sequence of bytes.</summary>
      /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
      /// <param name="s">The string containing the characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="s" /> is null. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      byte[] GetBytes(string s);

      /// <summary>When overridden in a derived class, encodes a set of characters from the specified string into the specified byte array.</summary>
      /// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
      /// <param name="s">The string containing the set of characters to encode. </param>
      /// <param name="charIndex">The index of the first character to encode. </param>
      /// <param name="charCount">The number of characters to encode. </param>
      /// <param name="bytes">The byte array to contain the resulting sequence of bytes. </param>
      /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="s" /> is null.-or- <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.-or- <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="s" />.-or- <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex);

      /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding all the bytes in the specified byte array.</summary>
      /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      int GetCharCount(byte[] bytes);

      /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary>
      /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <param name="index">The index of the first byte to decode. </param>
      /// <param name="count">The number of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      int GetCharCount(byte[] bytes, int index, int count);

      /// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a set of characters.</summary>
      /// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      char[] GetChars(byte[] bytes);

      /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a set of characters.</summary>
      /// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <param name="index">The index of the first byte to decode. </param>
      /// <param name="count">The number of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      char[] GetChars(byte[] bytes, int index, int count);

      /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into the specified character array.</summary>
      /// <returns>The actual number of characters written into <paramref name="chars" />.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <param name="byteIndex">The index of the first byte to decode. </param>
      /// <param name="byteCount">The number of bytes to decode. </param>
      /// <param name="chars">The character array to contain the resulting set of characters. </param>
      /// <param name="charIndex">The index at which to start writing the resulting set of characters. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null.-or- <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.-or- <paramref name="byteIndex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.-or- <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

      /// <summary>When overridden in a derived class, obtains a decoder that converts an encoded sequence of bytes into a sequence of characters.</summary>
      /// <returns>A <see cref="T:System.Text.Decoder" /> that converts an encoded sequence of bytes into a sequence of characters.</returns>
      IDecoder GetDecoder();

      /// <summary>When overridden in a derived class, obtains an encoder that converts a sequence of Unicode characters into an encoded sequence of bytes.</summary>
      /// <returns>A <see cref="T:System.Text.Encoder" /> that converts a sequence of Unicode characters into an encoded sequence of bytes.</returns>
      IEncoder GetEncoder();

      /// <summary>When overridden in a derived class, calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
      /// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
      /// <param name="charCount">The number of characters to encode. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="charCount" /> is less than zero. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      int GetMaxByteCount(int charCount);

      /// <summary>When overridden in a derived class, calculates the maximum number of characters produced by decoding the specified number of bytes.</summary>
      /// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
      /// <param name="byteCount">The number of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="byteCount" /> is less than zero. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      int GetMaxCharCount(int byteCount);

      /// <summary>When overridden in a derived class, returns a sequence of bytes that specifies the encoding used.</summary>
      /// <returns>A byte array containing a sequence of bytes that specifies the encoding used.-or- A byte array of length zero, if a preamble is not required.</returns>
      byte[] GetPreamble();

      /// <summary>When overridden in a derived class, decodes a sequence of bytes from the specified byte array into a string.</summary>
      /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <param name="index">The index of the first byte to decode. </param>
      /// <param name="count">The number of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="index" /> or <paramref name="count" /> is less than zero.-or- <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      string GetString(byte[] bytes, int index, int count);

      /// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary>
      /// <returns>The number of bytes produced by encoding the specified characters.</returns>
      /// <param name="chars">A pointer to the first character to encode. </param>
      /// <param name="count">The number of characters to encode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="count" /> is less than zero. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      /// <filterpriority>1</filterpriority>
      unsafe int GetByteCount(char* chars, int count);

      /// <summary>When overridden in a derived class, encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary>
      /// <returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns>
      /// <param name="chars">A pointer to the first character to encode. </param>
      /// <param name="charCount">The number of characters to encode. </param>
      /// <param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes. </param>
      /// <param name="byteCount">The maximum number of bytes to write. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="chars" /> is null.-or- <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="byteCount" /> is less than the resulting number of bytes. </exception>
      /// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
      /// <filterpriority>1</filterpriority>
      unsafe int GetBytes(char* chars, int charCount, byte* bytes, int byteCount);

      /// <summary>When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary>
      /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">A pointer to the first byte to decode. </param>
      /// <param name="count">The number of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="count" /> is less than zero. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      /// <filterpriority>1</filterpriority>
      unsafe int GetCharCount(byte* bytes, int count);

      /// <summary>When overridden in a derived class, decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary>
      /// <returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns>
      /// <param name="bytes">A pointer to the first byte to decode. </param>
      /// <param name="byteCount">The number of bytes to decode. </param>
      /// <param name="chars">A pointer to the location at which to start writing the resulting set of characters. </param>
      /// <param name="charCount">The maximum number of characters to write. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null.-or- <paramref name="chars" /> is null. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero. </exception>
      /// <exception cref="T:System.ArgumentException">
      /// <paramref name="charCount" /> is less than the resulting number of characters. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      /// <filterpriority>1</filterpriority>
      unsafe int GetChars(byte* bytes, int byteCount, char* chars, int charCount);

      /// <summary>When overridden in a derived class, decodes all the bytes in the specified byte array into a string.</summary>
      /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
      /// <param name="bytes">The byte array containing the sequence of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentException">The byte array contains invalid Unicode code points.</exception>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is null. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
      /// <filterpriority>1</filterpriority>
      string GetString(byte[] bytes);

      /// <summary>When overridden in a derived class, decodes a specified number of bytes starting at a specified address into a string. </summary>
      /// <returns>A string that contains the results of decoding the specified sequence of bytes. </returns>
      /// <param name="bytes">A pointer to a byte array. </param>
      /// <param name="byteCount">The number of bytes to decode. </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="bytes" /> is a null pointer. </exception>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// <paramref name="byteCount" /> is less than zero. </exception>
      /// <exception cref="T:System.Text.DecoderFallbackException">A   fallback occurred (see Character Encoding in the .NET Framework for a complete explanation)-and-<see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />. </exception>
      unsafe string GetString(byte* bytes, int byteCount);

      /// <summary>Gets a value indicating whether the current encoding is always normalized, using the default normalization form.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> is always normalized; otherwise, false. The default is false.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsAlwaysNormalized();

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding is always normalized, using the specified normalization form.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> object is always normalized using the specified <see cref="T:System.Text.NormalizationForm" /> value; otherwise, false. The default is false.</returns>
      /// <param name="form">One of the <see cref="T:System.Text.NormalizationForm" /> values. </param>
      /// <filterpriority>2</filterpriority>
      bool IsAlwaysNormalized(NormalizationForm form);

      /// <summary>When overridden in a derived class, gets a name for the current encoding that can be used with mail agent body tags.</summary>
      /// <returns>A name for the current <see cref="T:System.Text.Encoding" /> that can be used with mail agent body tags.-or- An empty string (""), if the current <see cref="T:System.Text.Encoding" /> cannot be used.</returns>
      /// <filterpriority>2</filterpriority>
      string BodyName { get; }

      /// <summary>When overridden in a derived class, gets the human-readable description of the current encoding.</summary>
      /// <returns>The human-readable description of the current <see cref="T:System.Text.Encoding" />.</returns>
      /// <filterpriority>2</filterpriority>
      string EncodingName { get; }

      /// <summary>When overridden in a derived class, gets a name for the current encoding that can be used with mail agent header tags.</summary>
      /// <returns>A name for the current <see cref="T:System.Text.Encoding" /> to use with mail agent header tags.-or- An empty string (""), if the current <see cref="T:System.Text.Encoding" /> cannot be used.</returns>
      /// <filterpriority>2</filterpriority>
      string HeaderName { get; }

      /// <summary>When overridden in a derived class, gets the Windows operating system code page that most closely corresponds to the current encoding.</summary>
      /// <returns>The Windows operating system code page that most closely corresponds to the current <see cref="T:System.Text.Encoding" />.</returns>
      /// <filterpriority>2</filterpriority>
      int WindowsCodePage { get; }

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by browser clients for displaying content.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by browser clients for displaying content; otherwise, false.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsBrowserDisplay { get; }

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by browser clients for saving content.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by browser clients for saving content; otherwise, false.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsBrowserSave { get; }

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by mail and news clients for displaying content.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by mail and news clients for displaying content; otherwise, false.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsMailNewsDisplay { get; }

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding can be used by mail and news clients for saving content.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> can be used by mail and news clients for saving content; otherwise, false.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsMailNewsSave { get; }

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding uses single-byte code points.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> uses single-byte code points; otherwise, false.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsSingleByte { get; }

      /// <summary>Gets or sets the <see cref="T:System.Text.EncoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary>
      /// <returns>The encoder fallback object for the current <see cref="T:System.Text.Encoding" /> object. </returns>
      /// <exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception>
      /// <filterpriority>2</filterpriority>
      EncoderFallback EncoderFallback { get; set; }

      /// <summary>Gets or sets the <see cref="T:System.Text.DecoderFallback" /> object for the current <see cref="T:System.Text.Encoding" /> object.</summary>
      /// <returns>The decoder fallback object for the current <see cref="T:System.Text.Encoding" /> object. </returns>
      /// <exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception>
      /// <exception cref="T:System.InvalidOperationException">A value cannot be assigned in a set operation because the current <see cref="T:System.Text.Encoding" /> object is read-only.</exception>
      /// <filterpriority>2</filterpriority>
      DecoderFallback DecoderFallback { get; set; }

      /// <summary>When overridden in a derived class, gets a value indicating whether the current encoding is read-only.</summary>
      /// <returns>true if the current <see cref="T:System.Text.Encoding" /> is read-only; otherwise, false. The default is true.</returns>
      /// <filterpriority>2</filterpriority>
      bool IsReadOnly { get; }

      /// <summary>When overridden in a derived class, gets the code page identifier of the current <see cref="T:System.Text.Encoding" />.</summary>
      /// <returns>The code page identifier of the current <see cref="T:System.Text.Encoding" />.</returns>
      /// <filterpriority>2</filterpriority>
      int CodePage { get; }
   }
}
