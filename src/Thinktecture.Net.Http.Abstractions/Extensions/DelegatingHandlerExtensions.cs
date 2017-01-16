using System.Net.Http;
using Thinktecture.Net.Http;
using Thinktecture.Net.Http.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="DelegatingHandler"/>.
	/// </summary>
	public static class DelegatingHandlerExtensions
	{
		/// <summary>
		/// Converts provided handler to <see cref="IDelegatingHandler"/>.
		/// </summary>
		/// <param name="handler">Handler to convert.</param>
		/// <returns>Converted handler.</returns>
		public static IDelegatingHandler ToInterface(this DelegatingHandler handler)
		{
			return (handler == null) ? null : new DelegatingHandlerAdapter(handler);
		}

		/// <summary>
		/// Converts provided <see cref="IDelegatingHandler"/> info to <see cref="DelegatingHandler"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IDelegatingHandler"/> to convert.</param>
		/// <returns>An instance of <see cref="DelegatingHandler"/>.</returns>
		public static DelegatingHandler ToImplementation(this IDelegatingHandler abstraction)
		{
			return ((IAbstraction<DelegatingHandler>)abstraction)?.UnsafeConvert();
		}
	}
}