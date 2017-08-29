using System.Net.Http;
using JetBrains.Annotations;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="HttpMessageInvoker"/>.
	/// </summary>
	public static class HttpMessageInvokerExtensions
	{
		/// <summary>
		/// Converts provided invoker to <see cref="IHttpMessageInvoker"/>.
		/// </summary>
		/// <param name="invoker">Invoker to convert.</param>
		/// <returns>Converted invoker.</returns>
		[CanBeNull]
		public static IHttpMessageInvoker ToInterface([CanBeNull] this HttpMessageInvoker invoker)
		{
			return (invoker == null) ? null : new HttpMessageInvokerAdapter(invoker);
		}
	}
}
