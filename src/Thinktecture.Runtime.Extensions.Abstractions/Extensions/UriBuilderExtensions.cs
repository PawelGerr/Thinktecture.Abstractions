using System;
using Thinktecture.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="UriBuilder"/>.
	/// </summary>
	public static class UriBuilderExtensions
	{
		/// <summary>
		/// Converts provided instance of <see cref="UriBuilder"/> to <see cref="IUriBuilder"/>.
		/// </summary>
		/// <param name="builder">Instance of <see cref="UriBuilder"/> to convert.</param>
		/// <returns>An instance of <see cref="IUriBuilder"/>.</returns>
		public static IUriBuilder ToInterface(this UriBuilder builder)
		{
			return (builder == null) ? null : new UriBuilderAdapter(builder);
		}
		
		/// <summary>
		/// Converts provided instance of <see cref="IUriBuilder"/> to <see cref="UriBuilder"/>.
		/// </summary>
		/// <param name="builder">Instance of <see cref="IUriBuilder"/> to convert.</param>
		/// <returns>An instance of <see cref="UriBuilder"/>.</returns>
		public static UriBuilder ToImplementation(this IUriBuilder builder)
		{
			return builder?.UnsafeConvert();
		}
	}
}