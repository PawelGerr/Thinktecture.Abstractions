#if NETCOREAPP || NET5_0
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Thinktecture.Net.Adapters;

namespace Thinktecture.Net
{
   /// <summary>
   /// Abstractions for static methods of <see cref="IPEndPoint"/>.
   /// </summary>
   public interface IIPEndPointGlobals
   {
      // ReSharper disable once InconsistentNaming
      private class IPEndPointGlobals : IIPEndPointGlobals
      {
      }

      /// <summary>
      /// Default implementation.
      /// </summary>
      public static readonly IIPEndPointGlobals Instance = new IPEndPointGlobals();

      /// <summary>
      /// Tries to convert an IP network endpoint (address and port) represented as a string to its IPEndPoint equivalent, and returns a value that indicates whether the conversion succeeded.
      /// </summary>
      /// <param name="s">The IP endpoint to validate.</param>
      /// <param name="result">When this method returns, the IPEndPoint version of s.</param>
      /// <returns><c>true</c> if <paramref name="s"/> can be parsed as an IP endpoint; otherwise, <c>false</c>.</returns>
      bool TryParse(string s, [NotNullWhen(true)] out IIPEndPoint? result)
      {
         if (IPEndPoint.TryParse(s, out var endpoint))
         {
            result = new IPEndPointAdapter(endpoint);
            return true;
         }

         result = null;
         return false;
      }

      /// <summary>
      /// Tries to convert an IP network endpoint (address and port) represented as a read-only span to its IPEndPoint equivalent, and returns a value that indicates whether the conversion succeeded.
      /// </summary>
      /// <param name="s">The IP endpoint to validate.</param>
      /// <param name="result">When this method returns, the IPEndPoint version of s.</param>
      /// <returns><c>true</c> if <paramref name="s"/> can be parsed as an IP endpoint; otherwise, <c>false</c>.</returns>
      bool TryParse(ReadOnlySpan<char> s, [NotNullWhen(true)] out IIPEndPoint? result)
      {
         if (IPEndPoint.TryParse(s, out var endpoint))
         {
            result = new IPEndPointAdapter(endpoint);
            return true;
         }

         result = null;
         return false;
      }

      /// <summary>
      /// Converts an IP network endpoint (address and port) represented as a string to an IPEndPoint instance.
      /// </summary>
      /// <param name="s">A string that contains an IP endpoint in dotted-quad notation or network byte order for IPv4 and in colon-hexadecimal notation for IPv6.</param>
      /// <returns>The object representation of an IP network endpoint.</returns>
      IIPEndPoint Parse(string s)
      {
         return IPEndPoint.Parse(s).ToInterface();
      }

      /// <summary>
      /// Converts an IP network endpoint (address and port) represented as a read-only span to an IPEndPoint instance.
      /// </summary>
      /// <param name="s">A read-only span that contains an IP endpoint in dotted-quad notation or network byte order for IPv4 and in colon-hexadecimal notation for IPv6.</param>
      /// <returns>The object representation of an IP network endpoint.</returns>
      IIPEndPoint Parse(ReadOnlySpan<char> s)
      {
         return IPEndPoint.Parse(s).ToInterface();
      }
   }
}
#endif
