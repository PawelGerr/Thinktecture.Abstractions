using System.Text;
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
		public static IDecoder ToInterface(this Decoder decoder)
		{
			return (decoder == null) ? null : new DecoderAdapter(decoder);
		}
	}
}