using System.Collections.Generic;
using System.Net.Http;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http
{
	/// <summary>Provides a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IMultipartContent : IHttpContent, IEnumerable<IHttpContent>, IAbstraction<MultipartContent>
	{
		/// <summary>Add multipart HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add([NotNull] HttpContent content);

		/// <summary>Add multipart HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized using the multipart/* content type specification.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add([NotNull] IHttpContent content);
	}
}
