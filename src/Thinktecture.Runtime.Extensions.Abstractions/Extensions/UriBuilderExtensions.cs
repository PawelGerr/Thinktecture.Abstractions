using System;
using Thinktecture.Adapters;

namespace Thinktecture
{
	public static class UriBuilderExtensions
	{
		/// <summary>
		/// Converts provided instance of <see cref="UriBuilder"/> to <see cref="IUriBuilder"/>.
		/// </summary>
		/// <param name="builder">Instance of <see cref="UriBuilder"/> to convert.</param>
		/// <returns>An instance of <see cref="IUriBuilder"/>.</returns>
		public static IUriBuilder ToInterface(this UriBuilder builder)
		{
			return new UriBuilderAdapter(builder);
		}
	}
}