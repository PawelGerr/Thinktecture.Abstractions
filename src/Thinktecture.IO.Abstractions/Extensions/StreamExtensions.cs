using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IO.Adapters;

namespace Thinktecture.IO
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