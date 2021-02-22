using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using Thinktecture.IO.Pipes;
using Thinktecture.IO.Pipes.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="NamedPipeServerStream"/>.
	/// </summary>
	public static class NamedPipeServerStreamExtensions
	{
		/// <summary>
		/// Converts provided <see cref="NamedPipeServerStream"/> to <see cref="INamedPipeServerStream"/>.
		/// </summary>
		/// <param name="stream"><see cref="NamedPipeServerStream"/> to convert.</param>
		/// <returns>An instance of <see cref="INamedPipeServerStream"/>.</returns>
      [return:NotNullIfNotNull("stream")]
      public static INamedPipeServerStream? ToInterface(this NamedPipeServerStream? stream)
		{
			return stream == null ? null : new NamedPipeServerStreamAdapter(stream);
		}
	}
}
