using System;
using System.ComponentModel;
using System.Net.Http;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Http.Adapters
{
	/// <summary>A type for HTTP handlers that delegate the processing of HTTP response messages to another handler, called the inner handler.</summary>
	public class DelegatingHandlerAdapter : HttpMessageHandlerAdapter, IDelegatingHandler
	{
		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new DelegatingHandler Implementation { get; }

		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new DelegatingHandler UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>Gets or sets the inner handler which processes the HTTP response messages.</summary>
		/// <returns>Returns <see cref="T:System.Net.Http.HttpMessageHandler" />.The inner handler for HTTP response messages.</returns>
		public IHttpMessageHandler InnerHandler
		{
			get => Implementation.InnerHandler.ToInterface();
			set => Implementation.InnerHandler = value.ToImplementation();
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Http.DelegatingHandler" /> class.</summary>
		/// <param name="handler">The implementation to use by the adapter.</param>
		public DelegatingHandlerAdapter([NotNull] DelegatingHandler handler)
			: base(handler)
		{
			Implementation = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
