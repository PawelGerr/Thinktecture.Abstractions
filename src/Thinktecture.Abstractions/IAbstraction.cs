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

	/// <summary>
	/// Represent an abstraction.
	/// </summary>
	/// <typeparam name="TImplementation">Type of the implementation.</typeparam>
	public interface IAbstraction<out TImplementation> : IAbstraction
	{
		/// <summary>
		/// Gets inner instance of the abstraction.
		/// It is not intended to be used directly. Use extension method <c>ToImplementation</c> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new TImplementation UnsafeConvert();
	}
}
