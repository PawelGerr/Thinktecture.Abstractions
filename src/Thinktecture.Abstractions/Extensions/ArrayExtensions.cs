namespace Thinktecture.Extensions
{
	/// <summary>
	/// Extensions for arrays
	/// </summary>
	public static class ArrayExtensions
	{
		/// <summary>
		/// Copies and converts abstractions to implementations.
		/// </summary>
		/// <typeparam name="TAbstraction">Type of the abstraction.</typeparam>
		/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
		/// <param name="abstractions">Array with abstractions.</param>
		/// <returns></returns>
		public static TImplementation[] ToImplementation<TAbstraction, TImplementation>(this TAbstraction[] abstractions)
			where TAbstraction : IAbstraction
		{
			if (abstractions == null)
				return null;

			var implementations = new TImplementation[abstractions.Length];

			for (var i = 0; i < abstractions.Length; i++)
			{
				implementations[i] = (TImplementation) abstractions[i]?.UnsafeConvert();
			}

			return implementations;
		}
	}
}