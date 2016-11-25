using System;
using System.ComponentModel;

namespace Thinktecture
{
	/// <summary>
	/// Represent an abstraction.
	/// </summary>
	public interface IAbstraction
	{
		/// <summary>
		/// Gets inner instance of the abstraction.
		/// It is not intended to be used directly. Use extension method <c>ToImplementation</c> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		object UnsafeConvert();
	}
}