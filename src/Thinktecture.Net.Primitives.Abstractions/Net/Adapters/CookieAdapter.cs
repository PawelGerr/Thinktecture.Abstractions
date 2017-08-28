using System;
using System.Net;
using JetBrains.Annotations;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.Net.Adapters
{
	/// <summary>Provides a set of properties and methods that are used to manage cookies. This class cannot be inherited.</summary>
	public class CookieAdapter : AbstractionAdapter<Cookie>, ICookie
	{
		/// <inheritdoc />
		public string Comment
		{
			get => Implementation.Comment;
			set => Implementation.Comment = value;
		}

		/// <inheritdoc />
		public Uri CommentUri
		{
			get => Implementation.CommentUri;
			set => Implementation.CommentUri = value;
		}

		/// <inheritdoc />
		public bool Discard
		{
			get => Implementation.Discard;
			set => Implementation.Discard = value;
		}

		/// <inheritdoc />
		public string Domain
		{
			get => Implementation.Domain;
			set => Implementation.Domain = value;
		}

		/// <inheritdoc />
		public bool Expired
		{
			get => Implementation.Expired;
			set => Implementation.Expired = value;
		}

		/// <inheritdoc />
		public DateTime Expires
		{
			get => Implementation.Expires;
			set => Implementation.Expires = value;
		}

		/// <inheritdoc />
		public bool HttpOnly
		{
			get => Implementation.HttpOnly;
			set => Implementation.HttpOnly = value;
		}

		/// <inheritdoc />
		public string Name
		{
			get => Implementation.Name;
			set => Implementation.Name = value;
		}

		/// <inheritdoc />
		public string Path
		{
			get => Implementation.Path;
			set => Implementation.Path = value;
		}

		/// <inheritdoc />
		public string Port
		{
			get => Implementation.Port;
			set => Implementation.Port = value;
		}

		/// <inheritdoc />
		public bool Secure
		{
			get => Implementation.Secure;
			set => Implementation.Secure = value;
		}

		/// <inheritdoc />
		public DateTime TimeStamp => Implementation.TimeStamp;

		/// <inheritdoc />
		public string Value
		{
			get => Implementation.Value;
			set => Implementation.Value = value;
		}

		/// <inheritdoc />
		public int Version
		{
			get => Implementation.Version;
			set => Implementation.Version = value;
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
		public CookieAdapter([NotNull] string name, [CanBeNull] string value)
			: this(new Cookie(name, value))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CookieAdapter" /> class with a specified <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, and <see cref="P:System.Net.Cookie.Path" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <param name="path">The subset of URIs on the origin server to which this <see cref="T:System.Net.Cookie" /> applies. The default value is "/". </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character.</exception>
		public CookieAdapter([NotNull] string name, [CanBeNull] string value, [CanBeNull] string path)
			: this(new Cookie(name, value, path))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="CookieAdapter" /> class with a specified <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, and <see cref="P:System.Net.Cookie.Domain" />.</summary>
		/// <param name="name">The name of a <see cref="T:System.Net.Cookie" />. The following characters must not be used inside <paramref name="name" />: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character. </param>
		/// <param name="value">The value of a <see cref="T:System.Net.Cookie" /> object. The following characters must not be used inside <paramref name="value" />: semicolon, comma. </param>
		/// <param name="path">The subset of URIs on the origin server to which this <see cref="T:System.Net.Cookie" /> applies. The default value is "/". </param>
		/// <param name="domain">The optional internet domain for which this <see cref="T:System.Net.Cookie" /> is valid. The default value is the host this <see cref="T:System.Net.Cookie" /> has been received from. </param>
		/// <exception cref="T:System.Net.CookieException">The <paramref name="name" /> parameter is null. -or- The <paramref name="name" /> parameter is of zero length. -or- The <paramref name="name" /> parameter contains an invalid character.-or- The <paramref name="value" /> parameter is null .-or - The <paramref name="value" /> parameter contains a string not enclosed in quotes that contains an invalid character.</exception>
		public CookieAdapter([NotNull] string name, [CanBeNull] string value, [CanBeNull] string path, [CanBeNull] string domain)
			: this(new Cookie(name, value, path, domain))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CookieAdapter" /> class.
		/// </summary>
		/// <param name="cookie">Cookie to be used by the adapter.</param>
		public CookieAdapter([NotNull] Cookie cookie)
			: base(cookie)
		{
		}
	}
}
