#if NET45 || NETSTANDARD2_0

using System.Net.Cache;
using JetBrains.Annotations;

namespace Thinktecture.Net.Cache.Adapters
{
	/// <summary>Defines an application's caching requirements for resources obtained by using <see cref="T:System.Net.WebRequest" /> objects.</summary>
	public class RequestCachePolicyAdapter : AbstractionAdapter<RequestCachePolicy>, IRequestCachePolicy
	{
		/// <summary>Gets the <see cref="T:System.Net.Cache.RequestCacheLevel" /> value specified when this instance was constructed.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> value that specifies the cache behavior for resources obtained using <see cref="T:System.Net.WebRequest" /> objects.</returns>
		public RequestCacheLevel Level => Implementation.Level;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cache.RequestCachePolicy" /> class. </summary>
		public RequestCachePolicyAdapter()
			: this(new RequestCachePolicy())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Cache.RequestCachePolicy" /> class. using the specified cache policy.</summary>
		/// <param name="level">A <see cref="T:System.Net.Cache.RequestCacheLevel" /> that specifies the cache behavior for resources obtained using <see cref="T:System.Net.WebRequest" /> objects. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">level is not a valid <see cref="T:System.Net.Cache.RequestCacheLevel" />.value.</exception>
		public RequestCachePolicyAdapter(RequestCacheLevel level)
			: this(new RequestCachePolicy(level))
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="RequestCachePolicyAdapter"/>.
		/// </summary>
		/// <param name="policy">Policy to use by the adapter.</param>
		public RequestCachePolicyAdapter([NotNull] RequestCachePolicy policy)
			: base(policy)
		{
		}
	}
}

#endif
