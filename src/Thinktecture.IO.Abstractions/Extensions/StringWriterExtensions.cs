using System;
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="StringWriter"/>.
	/// </summary>
	public static class StringWriterExtensions
	{
		/// <summary>
		/// Converts provided writer to <see cref="IStringWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		[CanBeNull]
		public static IStringWriter ToInterface([CanBeNull] this StringWriter writer)
		{
			return (writer == null) ? null : new StringWriterAdapter(writer);
		}

		/// <summary>
		/// Converts provided <see cref="IStringWriter"/> info to <see cref="StringWriter"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IStringWriter"/> to convert.</param>
		/// <returns>An instance of <see cref="StringWriter"/>.</returns>
		[CanBeNull]
		public static StringWriter ToImplementation([CanBeNull] this IStringWriter abstraction)
		{
			return ((IAbstraction<StringWriter>)abstraction)?.UnsafeConvert();
		}
	}
}
