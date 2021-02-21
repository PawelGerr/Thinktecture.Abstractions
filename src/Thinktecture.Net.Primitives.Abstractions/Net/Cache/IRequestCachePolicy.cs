using System.Net.Cache;

namespace Thinktecture.Net.Cache
{
	/// <summary>Defines an application's caching requirements for resources obtained by using <see cref="T:System.Net.WebRequest" /> objects.</summary>
	public interface IRequestCachePolicy
	{
		/// <summary>Gets the <see cref="T:System.Net.Cache.RequestCacheLevel" /> value specified when this instance was constructed.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> value that specifies the cache behavior for resources obtained using <see cref="T:System.Net.WebRequest" /> objects.</returns>
		RequestCacheLevel Level { get; }
	}
}
