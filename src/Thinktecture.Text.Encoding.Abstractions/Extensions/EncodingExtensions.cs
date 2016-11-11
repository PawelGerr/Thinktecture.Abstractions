using System;
using System.Text;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Encoding"/>.
	/// </summary>
	public static class EncodingExtensions
	{
		/// <summary>
		/// Converts provided encoding to <see cref="IEncoding"/>.
		/// </summary>
		/// <param name="encoding">Encoding to convert.</param>
		/// <returns>Converted encoding.</returns>
		public static IEncoding ToInterface(this Encoding encoding)
		{
			return (encoding == null) ? null : new EncodingAdapter(encoding);
		}

		/// <summary>
		/// Converts provided encoding to <see cref="Encoding"/>.
		/// </summary>
		/// <param name="encoding">Encoding to convert.</param>
		/// <returns>Converted encoding.</returns>
		public static Encoding ToImplementation(this IEncoding encoding)
		{
			return encoding?.UnsafeConvert();
		}
	}
}