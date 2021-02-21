using System.Diagnostics.CodeAnalysis;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Stream"/>.
	/// </summary>
	public static class StreamExtensions
	{
		/// <summary>
		/// Converts provided stream to <see cref="IStream"/>.
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
      [return: NotNullIfNotNull("stream")]
		public static IStream? ToInterface(this Stream? stream)
		{
			if (stream == null)
				return null;

			if (ReferenceEquals(stream, Stream.Null))
				return StreamAdapter.Null;

			return new StreamAdapter(stream);
		}
	}
}
