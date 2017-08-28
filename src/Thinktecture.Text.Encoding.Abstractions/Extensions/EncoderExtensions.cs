using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IEncoder ToInterface([CanBeNull] this Encoder encoder)
		{
			return (encoder == null) ? null : new EncoderAdapter(encoder);
		}
	}
}
