using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpResponseMessage"/>.
	/// </summary>
	public static class HttpResponseMessageExtensions
	{
		/// <summary>
		/// Converts provided message to <see cref="IHttpResponseMessage"/>.
		/// </summary>
		/// <param name="message">Message to convert.</param>
		/// <returns>Converted message.</returns>
		[CanBeNull]
		public static IHttpResponseMessage ToInterface([CanBeNull] this HttpResponseMessage message)
		{
			return (message == null) ? null : new HttpResponseMessageAdapter(message);
		}
	}
}
