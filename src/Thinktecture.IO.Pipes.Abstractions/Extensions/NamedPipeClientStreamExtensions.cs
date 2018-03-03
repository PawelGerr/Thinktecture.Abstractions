using System.IO.Pipes;
using JetBrains.Annotations;
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
		[CanBeNull]
		public static INamedPipeClientStream ToInterface([CanBeNull] this NamedPipeClientStream stream)
		{
			return (stream == null) ? null : new NamedPipeClientStreamAdapter(stream);
		}
	}
}
