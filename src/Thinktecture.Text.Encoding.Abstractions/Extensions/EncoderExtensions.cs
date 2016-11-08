using System.Text;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="Encoder"/>.
	/// </summary>
	public static class EncoderExtensions
	{
		/// <summary>
		/// Converts provided encoder to <see cref="IEncoder"/>.
		/// </summary>
		/// <param name="encoder">Encoder to convert.</param>
		/// <returns>Converted encoder.</returns>
		public static IEncoder ToInterface(this Encoder encoder)
		{
			return (encoder == null) ? null : new EncoderAdapter(encoder);
		}
		
		/// <summary>
		/// Converts provided encoder to <see cref="Encoder"/>.
		/// </summary>
		/// <param name="encoder">Encoder to convert.</param>
		/// <returns>Converted encoder.</returns>
		public static Encoder ToImplementation(this IEncoder encoder)
		{
			return encoder?.InternalInstance;
		}
	}
}