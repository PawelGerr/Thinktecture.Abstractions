using System;
using System.ComponentModel;

namespace Thinktecture
{
	/// <summary>Represents the base class for classes that contain event data, and provides a value to use for events that do not include event data. </summary>
	/// <filterpriority>1</filterpriority>
	public interface IEventArgs : IAbstraction
	{
		/// <summary>
		/// Gets inner instance of <see cref="EventArgs"/>.
		/// It is not intended to be used directly. Use <see cref="EventArgsExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new EventArgs UnsafeConvert();
	}
}