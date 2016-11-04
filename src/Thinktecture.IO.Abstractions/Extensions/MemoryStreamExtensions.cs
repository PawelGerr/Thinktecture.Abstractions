using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Thinktecture.IO.Extensions
{
    public static class MemoryStreamExtensions
    {
		/// <summary>
		/// Converts provided stream to <see cref="IMemoryStream"/>;
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
	    public static IMemoryStream ToInterface(this MemoryStream stream)
	    {
		    return new MemoryStreamAdapter(stream);
	    }
    }
}
