using System;
using System.Text;
using Thinktecture.Text;
using Thinktecture.Text.Adapters;

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
		public static IStringBuilder ToInterface(this StringBuilder builder)
		{
			return (builder == null) ? null : new StringBuilderAdapter(builder);
		}

		/// <summary>
		/// Converts provided <see cref="IStringBuilder"/> to <see cref="StringBuilder"/>.
		/// </summary>
		/// <param name="builder"><see cref="IStringBuilder"/> to convert.</param>
		/// <returns>An instance of <see cref="StringBuilder"/>.</returns>
		public static StringBuilder ToImplementation(this IStringBuilder builder)
		{
			return builder?.UnsafeConvert();
		}
	}
}