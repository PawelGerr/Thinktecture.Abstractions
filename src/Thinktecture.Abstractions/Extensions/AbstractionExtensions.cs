using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IAbstraction"/>.
	/// </summary>
	public static class AbstractionExtensions
	{
		/// <summary>
		/// Converts provided abstraction to implementation.
		/// </summary>
		/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
		/// <param name="abstraction">Abstraction to convert.</param>
		/// <returns>Converted abstraction.</returns>
		[CanBeNull]
		public static TImplementation ToImplementation<TImplementation>([CanBeNull] this IAbstraction<TImplementation> abstraction)
		{
			return ReferenceEquals(abstraction, null) ? default : abstraction.UnsafeConvert();
		}
	}
}
