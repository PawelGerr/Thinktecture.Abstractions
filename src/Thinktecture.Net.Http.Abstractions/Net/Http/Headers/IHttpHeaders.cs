using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Thinktecture.Net.Http.Headers
{
   /// <summary>A collection of headers and their values as defined in RFC 2616.</summary>
   public interface IHttpHeaders : IAbstraction<HttpHeaders>, IEnumerable<KeyValuePair<string, IEnumerable<string>>>
   {
      /// <summary>Adds the specified header and its value into the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      /// <param name="name">The header to add to the collection.</param>
      /// <param name="value">The content of the header.</param>
      void Add(string name, string? value);

      /// <summary>Adds the specified header and its values into the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      /// <param name="name">The header to add to the collection.</param>
      /// <param name="values">A list of header values to add to the collection.</param>
      void Add(string name, IEnumerable<string> values);

      /// <summary>Returns a value that indicates whether the specified header and its value were added to the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection without validating the provided information.</summary>
      /// <returns>Returns <see cref="T:System.Boolean" />.true if the specified header <paramref name="name" /> and <paramref name="value" /> could be added to the collection; otherwise false.</returns>
      /// <param name="name">The header to add to the collection.</param>
      /// <param name="value">The content of the header.</param>
      bool TryAddWithoutValidation(string name, string? value);

      /// <summary>Returns a value that indicates whether the specified header and its values were added to the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection without validating the provided information.</summary>
      /// <returns>Returns <see cref="T:System.Boolean" />.true if the specified header <paramref name="name" /> and <paramref name="values" /> could be added to the collection; otherwise false.</returns>
      /// <param name="name">The header to add to the collection.</param>
      /// <param name="values">The values of the header.</param>
      bool TryAddWithoutValidation(string name, IEnumerable<string?> values);

      /// <summary>Removes all headers from the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      void Clear();

      /// <summary>Removes the specified header from the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      /// <returns>Returns <see cref="T:System.Boolean" />.</returns>
      /// <param name="name">The name of the header to remove from the collection. </param>
      bool Remove(string name);

      /// <summary>Returns all header values for a specified header stored in the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      /// <returns>Returns <see cref="T:System.Collections.Generic.IEnumerable`1" />.An array of header strings.</returns>
      /// <param name="name">The specified header to return values for.</param>
      IEnumerable<string> GetValues(string name);

      /// <summary>Return if a specified header and specified values are stored in the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      /// <returns>Returns <see cref="T:System.Boolean" />.true is the specified header <paramref name="name" /> and values are stored in the collection; otherwise false.</returns>
      /// <param name="name">The specified header.</param>
      /// <param name="values">The specified header values.</param>
      bool TryGetValues(string name, [NotNullWhen(true)] out IEnumerable<string>? values);

      /// <summary>Returns if  a specific header exists in the <see cref="T:System.Net.Http.Headers.HttpHeaders" /> collection.</summary>
      /// <returns>Returns <see cref="T:System.Boolean" />.true is the specified header exists in the collection; otherwise false.</returns>
      /// <param name="name">The specific header.</param>
      bool Contains(string name);
   }
}
