using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	public static class StreamExtensions
	{
		/// <summary>
		/// Converts provided stream to <see cref="IStream"/>.
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
		public static IStream ToInterface(this Stream stream)
		{
			return new StreamAdapter(stream);
		}
	}
}