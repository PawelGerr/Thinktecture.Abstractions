using System;
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="StreamReader"/>.
	/// </summary>
	public static class StreamReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IStreamReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert</param>
		/// <returns>Converted reader.</returns>
		[CanBeNull]
		public static IStreamReader ToInterface([CanBeNull] this StreamReader reader)
		{
			if (reader == null)
				return null;

			if (ReferenceEquals(reader, StreamReader.Null))
				return StreamReaderAdapter.Null;

			return new StreamReaderAdapter(reader);
		}

		/// <summary>
		/// Converts provided <see cref="IStreamReader"/> info to <see cref="StreamReader"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IStreamReader"/> to convert.</param>
		/// <returns>An instance of <see cref="StreamReader"/>.</returns>
		[CanBeNull]
		public static StreamReader ToImplementation([CanBeNull] this IStreamReader abstraction)
		{
			return ((IAbstraction<StreamReader>)abstraction)?.UnsafeConvert();
		}
	}
}
