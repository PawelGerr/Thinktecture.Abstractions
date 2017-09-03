using System;
using JetBrains.Annotations;

namespace Thinktecture.Adapters
{
	/// <summary>Represents the base class for classes that contain event data, and provides a value to use for events that do not include event data. </summary>
	public class EventArgsAdapter : AbstractionAdapter<EventArgs>, IEventArgs
	{
		/// <summary>Provides a value to use with events that do not have event data.</summary>
		public static readonly IEventArgs Empty = new EventArgsAdapter(EventArgs.Empty);

		/// <summary>
		/// Initializes new instance of <see cref="EventArgsAdapter"/>.
		/// </summary>
		public EventArgsAdapter() :
			this(EventArgs.Empty)
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="EventArgsAdapter"/>.
		/// </summary>
		/// <param name="args">EventArgs to be used by the adapter</param>
		public EventArgsAdapter([NotNull] EventArgs args)
			: base(args)
		{
		}
	}
}
