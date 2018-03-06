#if NETSTANDARD1_5 || NETSTANDARD2_0
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="BufferedStream"/>.
	/// </summary>
	public static class BufferedStreamExtensions
	{
		/// <summary>
		/// Converts provided stream to <see cref="IBufferedStream"/>;
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
		[CanBeNull]
		public static IBufferedStream ToInterface([CanBeNull] this BufferedStream stream)
		{
			return (stream == null) ? null : new BufferedStreamAdapter(stream);
		}

		/// <summary>
		/// Converts provided <see cref="IBufferedStream"/> info to <see cref="BufferedStream"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IBufferedStream"/> to convert.</param>
		/// <returns>An instance of <see cref="BufferedStream"/>.</returns>
		[CanBeNull]
		public static BufferedStream ToImplementation([CanBeNull] this IBufferedStream abstraction)
		{
			return ((IAbstraction<BufferedStream>)abstraction)?.UnsafeConvert();
		}
	}
}
#endif
