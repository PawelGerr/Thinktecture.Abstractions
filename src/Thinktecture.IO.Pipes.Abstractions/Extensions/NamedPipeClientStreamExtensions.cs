using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using Thinktecture.IO.Pipes;
using Thinktecture.IO.Pipes.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="NamedPipeClientStream"/>.
	/// </summary>
	public static class NamedPipeClientStreamExtensions
	{
		/// <summary>
		/// Converts provided <see cref="NamedPipeClientStream"/> to <see cref="INamedPipeClientStream"/>.
		/// </summary>
		/// <param name="stream"><see cref="NamedPipeClientStream"/> to convert.</param>
		/// <returns>An instance of <see cref="INamedPipeClientStream"/>.</returns>
      [return:NotNullIfNotNull("stream")]
      public static INamedPipeClientStream? ToInterface(this NamedPipeClientStream? stream)
		{
			return stream == null ? null : new NamedPipeClientStreamAdapter(stream);
		}
	}
}
