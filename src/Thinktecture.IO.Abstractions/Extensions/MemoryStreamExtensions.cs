using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
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
