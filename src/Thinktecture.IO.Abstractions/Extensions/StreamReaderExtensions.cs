using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="StreamReader"/>.
	/// </summary>
	public static class StreamReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IStreamReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert</param>
		/// <returns>Converted reader.</returns>
		public static IStreamReader ToInterface(this StreamReader reader)
		{
			return (reader == null) ? null : new StreamReaderAdapter(reader);
		}

		/// <summary>
		/// Converts provided reader to <see cref="StreamReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert</param>
		/// <returns>Converted reader.</returns>
		public static StreamReader ToImplementation(this IStreamReader reader)
		{
			return reader?.InternalInstance;
		}
	}
}