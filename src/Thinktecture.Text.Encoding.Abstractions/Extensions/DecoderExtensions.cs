using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Decoder"/>.
	/// </summary>
	public static class DecoderExtensions
	{
		/// <summary>
		/// Converts provided decoder to <see cref="IDecoder"/>.
		/// </summary>
		/// <param name="decoder">Decoder to convert.</param>
		/// <returns>Converted decoder.</returns>
		[CanBeNull]
		public static IDecoder ToInterface([CanBeNull] this Decoder decoder)
		{
			return (decoder == null) ? null : new DecoderAdapter(decoder);
		}
	}
}
