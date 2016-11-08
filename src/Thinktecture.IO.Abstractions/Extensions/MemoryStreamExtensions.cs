using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MemoryStream"/>.
	/// </summary>
	public static class MemoryStreamExtensions
	{
		/// <summary>
		/// Converts provided stream to <see cref="IMemoryStream"/>;
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
		public static IMemoryStream ToInterface(this MemoryStream stream)
		{
			return (stream == null) ? null : new MemoryStreamAdapter(stream);
		}
		
		/// <summary>
		/// Converts provided stream to <see cref="MemoryStream"/>;
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
		public static MemoryStream ToImplementation(this IMemoryStream stream)
		{
			return stream?.InternalInstance;
		}
	}
}