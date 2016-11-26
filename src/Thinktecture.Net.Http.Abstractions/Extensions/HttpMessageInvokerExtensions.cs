using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

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
		public static IHttpMessageInvoker ToInterface(this HttpMessageInvoker invoker)
		{
			return (invoker == null) ? null : new HttpMessageInvokerAdapter(invoker);
		}

		/// <summary>
		/// Converts provided invoker to <see cref="HttpMessageInvoker"/>.
		/// </summary>
		/// <param name="invoker">Invoker to convert.</param>
		/// <returns>Converted invoker.</returns>
		public static HttpMessageInvoker ToImplementation(this IHttpMessageInvoker invoker)
		{
			return invoker?.UnsafeConvert();
		}
	}
}