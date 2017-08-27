using System;
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="BinaryReader"/>.
	/// </summary>
	public static class BinaryReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IBinaryReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert.</param>
		/// <returns>Converted reader.</returns>
		[CanBeNull]
		public static IBinaryReader ToInterface([CanBeNull] this BinaryReader reader)
		{
			return (reader == null) ? null : new BinaryReaderAdapter(reader);
		}
	}
}
