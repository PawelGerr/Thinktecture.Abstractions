using System.Net.Http.Headers;
using JetBrains.Annotations;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.Http.Headers
{
	/// <summary>Represents a collection of header values.</summary>
	/// <typeparam name="T">The header collection type.</typeparam>
	public interface IHttpHeaderValueCollection<T> : ICollectionAbstraction<T, HttpHeaderValueCollection<T>>
		where T : class
	{
		/// <summary>Parses and adds an entry to the <see cref="IHttpHeaderValueCollection{T}" />.</summary>
		/// <param name="input">The entry to add.</param>
		void ParseAdd([CanBeNull] string input);

		/// <summary>Determines whether the input could be parsed and added to the <see cref="IHttpHeaderValueCollection{T}" />.</summary>
		/// <returns>Returns <c>true</c> if the <paramref name="input" /> could be parsed and added to the <see cref="IHttpHeaderValueCollection{T}" /> instance; otherwise, <c>false</c>.</returns>
		/// <param name="input">The entry to validate.</param>
		bool TryParseAdd([CanBeNull] string input);
	}
}
