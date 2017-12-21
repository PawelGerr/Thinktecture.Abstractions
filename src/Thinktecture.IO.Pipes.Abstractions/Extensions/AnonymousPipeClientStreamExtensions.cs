using System.IO.Pipes;
using JetBrains.Annotations;
using Thinktecture.IO.Pipes;
using Thinktecture.IO.Pipes.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="AnonymousPipeClientStream"/>.
	/// </summary>
	public static class AnonymousPipeClientStreamExtensions
	{
		/// <summary>
		/// Converts provided <see cref="AnonymousPipeClientStream"/> to <see cref="IAnonymousPipeClientStream"/>.
		/// </summary>
		/// <param name="stream"><see cref="AnonymousPipeClientStream"/> to convert.</param>
		/// <returns>An instance of <see cref="IAnonymousPipeClientStream"/>.</returns>
		[CanBeNull]
		public static IAnonymousPipeClientStream ToInterface([CanBeNull] this AnonymousPipeClientStream stream)
		{
			return (stream == null) ? null : new AnonymousPipeClientStreamAdapter(stream);
		}
	}
}
