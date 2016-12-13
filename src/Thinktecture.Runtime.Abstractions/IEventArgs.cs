using System;

namespace Thinktecture
{
	/// <summary>Represents the base class for classes that contain event data, and provides a value to use for events that do not include event data. </summary>
	/// <filterpriority>1</filterpriority>
	public interface IEventArgs : IAbstraction<EventArgs>
	{
	}
}