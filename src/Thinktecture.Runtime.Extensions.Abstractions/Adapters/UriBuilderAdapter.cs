using System;

namespace Thinktecture.Adapters
{
	public class UriBuilderAdapter : IUriBuilder
	{
		private readonly UriBuilder _builder;

		public UriBuilderAdapter(UriBuilder builder)
		{
			if (builder == null)
				throw new ArgumentNullException(nameof(builder));

			_builder = builder;
		}

		/// <inheritdoc />
		public UriBuilder ToImplementation()
		{
			return _builder;
		}

		/// <inheritdoc />
		public string Fragment
		{
			get { return _builder.Fragment; }
			set { _builder.Fragment = value; }
		}

		/// <inheritdoc />
		public string Host
		{
			get { return _builder.Host; }
			set { _builder.Host = value; }
		}

		/// <inheritdoc />
		public string Password
		{
			get { return _builder.Password; }
			set { _builder.Password = value; }
		}

		/// <inheritdoc />
		public string Path
		{
			get { return _builder.Path; }
			set { _builder.Path = value; }
		}

		/// <inheritdoc />
		public int Port
		{
			get { return _builder.Port; }
			set { _builder.Port = value; }
		}

		/// <inheritdoc />
		public string Query
		{
			get { return _builder.Query; }
			set { _builder.Query = value; }
		}

		/// <inheritdoc />
		public string Scheme
		{
			get { return _builder.Scheme; }
			set { _builder.Scheme = value; }
		}

		/// <inheritdoc />
		public Uri Uri => _builder.Uri;

		/// <inheritdoc />
		public string UserName
		{
			get { return _builder.UserName; }
			set { _builder.UserName = value; }
		}
	}
}