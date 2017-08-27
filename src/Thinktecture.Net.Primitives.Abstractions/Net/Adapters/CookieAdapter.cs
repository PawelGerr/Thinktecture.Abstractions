using System;
using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides a set of properties and methods that are used to manage cookies. This class cannot be inherited.</summary>
	public class CookieAdapter : AbstractionAdapter, ICookie
	{
		private readonly Cookie _cookie;

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new Cookie UnsafeConvert()
		{
			return _cookie;
		}

		/// <inheritdoc />
		public string Comment
		{
			get => _cookie.Comment;
			set => _cookie.Comment = value;
		}

		/// <inheritdoc />
		public Uri CommentUri
		{
			get => _cookie.CommentUri;
			set => _cookie.CommentUri = value;
		}

		/// <inheritdoc />
		public bool Discard
		{
			get => _cookie.Discard;
			set => _cookie.Discard = value;
		}

		/// <inheritdoc />
		public string Domain
		{
			get => _cookie.Domain;
			set => _cookie.Domain = value;
		}

		/// <inheritdoc />
		public bool Expired
		{
			get => _cookie.Expired;
			set => _cookie.Expired = value;
		}

		/// <inheritdoc />
		public DateTime Expires
		{
			get => _cookie.Expires;
			set => _cookie.Expires = value;
		}

		/// <inheritdoc />
		public bool HttpOnly
		{
			get => _cookie.HttpOnly;
			set => _cookie.HttpOnly = value;
		}

		/// <inheritdoc />
		public string Name
		{
			get => _cookie.Name;
			set => _cookie.Name = value;
		}

		/// <inheritdoc />
		public string Path
		{
			get => _cookie.Path;
			set => _cookie.Path = value;
		}

		/// <inheritdoc />
		public string Port
		{
			get => _cookie.Port;
			set => _cookie.Port = value;
		}

		/// <inheritdoc />
		public bool Secure
		{
			get => _cookie.Secure;
			set => _cookie.Secure = value;
		}

		/// <inheritdoc />
		public DateTime TimeStamp => _cookie.TimeStamp;

		/// <inheritdoc />
		public string Value
		{
			get => _cookie.Value;
			set => _cookie.Value = value;
		}

		/// <inheritdoc />
		public int Version
		{
			get => _cookie.Version;
			set => _cookie.Version = value;
		}

		/// <summary>Initializes a new instance of the <see cref="CookieAdapter" /> class.</summary>
		public CookieAdapter()
			: this(new Cookie())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CookieAdapter" /> class with a specified <see cref="P:System.Net.Cookie.Name" /> and <see cref="P:System.Net.Cookie.Value" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character. </exception>
		public CookieAdapter(string name, string value)
			: this(new Cookie(name, value))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CookieAdapter" /> class with a specified <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, and <see cref="P:System.Net.Cookie.Path" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <param name="path">The subset of URIs on the origin server to which this <see cref="T:System.Net.Cookie" /> applies. The default value is "/". </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character.</exception>
		public CookieAdapter(string name, string value, string path)
			: this(new Cookie(name, value, path))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CookieAdapter" /> class with a specified <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, and <see cref="P:System.Net.Cookie.Domain" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" /> object. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <param name="path">The subset of URIs on the origin server to which this <see cref="T:System.Net.Cookie" /> applies. The default value is "/". </param>
		/// <param name="domain">The optional internet domain for which this <see cref="T:System.Net.Cookie" /> is valid. The default value is the host this <see cref="T:System.Net.Cookie" /> has been received from. </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character.</exception>
		public CookieAdapter(string name, string value, string path, string domain)
			: this(new Cookie(name, value, path, domain))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CookieAdapter" /> class.
		/// </summary>
		/// <param name="cookie">Cookie to be used by the adapter.</param>
		public CookieAdapter(Cookie cookie)
			: base(cookie)
		{
			_cookie = cookie ?? throw new ArgumentNullException(nameof(cookie));
		}
	}
}
