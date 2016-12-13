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
		/// <param name="abstraction">Abstraction to convert.</param>
		/// <returns>Converted abstraction.</returns>
		public static TImplementation ToImplementation<TImplementation>(this IAbstraction<TImplementation> abstraction)
		{
			return abstraction != null ? abstraction.UnsafeConvert() : default(TImplementation);
		}
	}
}