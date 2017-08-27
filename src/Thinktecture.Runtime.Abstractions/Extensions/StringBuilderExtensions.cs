using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="StringBuilder"/>.
	/// </summary>
	public static class StringBuilderExtensions
	{
		/// <summary>
		/// Converts provided <see cref="StringBuilder"/> to <see cref="IStringBuilder"/>.
		/// </summary>
		/// <param name="builder"><see cref="StringBuilder"/> to convert.</param>
		/// <returns>An instance of <see cref="IStringBuilder"/>.</returns>
		[CanBeNull]
		public static IStringBuilder ToInterface([CanBeNull] this StringBuilder builder)
		{
			return (builder == null) ? null : new StringBuilderAdapter(builder);
		}
	}
}
