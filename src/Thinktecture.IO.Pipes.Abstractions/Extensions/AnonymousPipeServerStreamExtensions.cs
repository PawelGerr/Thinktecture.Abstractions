using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using Thinktecture.IO.Pipes;
using Thinktecture.IO.Pipes.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="AnonymousPipeServerStream"/>.
	/// </summary>
	public static class AnonymousPipeServerStreamExtensions
	{
		/// <summary>
		/// Converts provided <see cref="AnonymousPipeServerStream"/> to <see cref="IAnonymousPipeServerStream"/>.
		/// </summary>
		/// <param name="stream"><see cref="AnonymousPipeServerStream"/> to convert.</param>
		/// <returns>An instance of <see cref="IAnonymousPipeServerStream"/>.</returns>
      [return:NotNullIfNotNull("stream")]
      public static IAnonymousPipeServerStream? ToInterface(this AnonymousPipeServerStream? stream)
		{
			return stream == null ? null : new AnonymousPipeServerStreamAdapter(stream);
		}
	}
}
