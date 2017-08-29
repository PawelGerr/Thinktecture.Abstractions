using System.Net.Http;
using JetBrains.Annotations;

namespace Thinktecture.Net.Http
{
	/// <summary>Provides a container for content encoded using multipart/form-data MIME type.</summary>
	// ReSharper disable once PossibleInterfaceMemberAmbiguity
	public interface IMultipartFormDataContent : IMultipartContent, IAbstraction<MultipartFormDataContent>
	{
		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add([NotNull] HttpContent content, [NotNull] string name);

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add([NotNull] IHttpContent content, [NotNull] string name);

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <param name="fileName">The file name for the HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.-or-The <paramref name="fileName" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add([NotNull] HttpContent content, [NotNull] string name, [NotNull] string fileName);

		/// <summary>Add HTTP content to a collection of <see cref="T:System.Net.Http.HttpContent" /> objects that get serialized to multipart/form-data MIME type.</summary>
		/// <param name="content">The HTTP content to add to the collection.</param>
		/// <param name="name">The name for the HTTP content to add.</param>
		/// <param name="fileName">The file name for the HTTP content to add to the collection.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> was null or contains only white space characters.-or-The <paramref name="fileName" /> was null or contains only white space characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> was null.</exception>
		void Add([NotNull] IHttpContent content, [NotNull] string name, [NotNull] string fileName);
	}
}
