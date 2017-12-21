using System.IO.Pipes;
using JetBrains.Annotations;
using Thinktecture.IO.Pipes;
using Thinktecture.IO.Pipes.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="PipeStream"/>.
	/// </summary>
	public static class PipeStreamExtensions
	{
		/// <summary>
		/// Converts provided <see cref="PipeStream"/> to <see cref="IPipeStream"/>.
		/// </summary>
		/// <param name="stream"><see cref="PipeStream"/> to convert.</param>
		/// <returns>An instance of <see cref="IPipeStream"/>.</returns>
		[CanBeNull]
		public static IPipeStream ToInterface([CanBeNull] this PipeStream stream)
		{
			return (stream == null) ? null : new PipeStreamAdapter(stream);
		}
	}
}
