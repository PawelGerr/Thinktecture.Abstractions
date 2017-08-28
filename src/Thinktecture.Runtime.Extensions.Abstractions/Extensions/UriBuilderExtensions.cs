using System;
using JetBrains.Annotations;
using Thinktecture.Adapters;

// ReSharper disable once CheckNamespace
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
		[CanBeNull]
		public static IUriBuilder ToInterface([CanBeNull] this UriBuilder builder)
		{
			return (builder == null) ? null : new UriBuilderAdapter(builder);
		}
	}
}
