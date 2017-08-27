using System;
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MemoryStream"/>.
	/// </summary>
	public static class MemoryStreamExtensions
	{
		/// <summary>
		/// Converts provided stream to <see cref="IMemoryStream"/>;
		/// </summary>
		/// <param name="stream">Stream to convert.</param>
		/// <returns>Converted stream.</returns>
		[CanBeNull]
		public static IMemoryStream ToInterface([CanBeNull] this MemoryStream stream)
		{
			return (stream == null) ? null : new MemoryStreamAdapter(stream);
		}

		/// <summary>
		/// Converts provided <see cref="IMemoryStream"/> info to <see cref="MemoryStream"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IMemoryStream"/> to convert.</param>
		/// <returns>An instance of <see cref="MemoryStream"/>.</returns>
		[CanBeNull]
		public static MemoryStream ToImplementation([CanBeNull] this IMemoryStream abstraction)
		{
			return ((IAbstraction<MemoryStream>)abstraction)?.UnsafeConvert();
		}
	}
}
