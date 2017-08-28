using System;
using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Encoding"/>.
	/// </summary>
	public static class EncodingExtensions
	{
		/// <summary>
		/// Converts provided encoding to <see cref="IEncoding"/>.
		/// </summary>
		/// <param name="encoding">Encoding to convert.</param>
		/// <returns>Converted encoding.</returns>
		[CanBeNull]
		public static IEncoding ToInterface([CanBeNull] this Encoding encoding)
		{
			return (encoding == null) ? null : new EncodingAdapter(encoding);
		}
	}
}
