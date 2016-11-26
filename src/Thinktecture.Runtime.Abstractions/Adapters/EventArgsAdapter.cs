using System;
using System.ComponentModel;

namespace Thinktecture.Adapters
{
	/// <summary>Represents the base class for classes that contain event data, and provides a value to use for events that do not include event data. </summary>
	/// <filterpriority>1</filterpriority>
	public class EventArgsAdapter : IEventArgs
	{
		private readonly EventArgs _args;

		/// <summary>Provides a value to use with events that do not have event data.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly IEventArgs Empty = new EventArgsAdapter(EventArgs.Empty);

		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public EventArgs UnsafeConvert()
		{
			return _args;
		}

		/// <summary>
		/// Initializes new instance of <see cref="EventArgsAdapter"/>.
		/// </summary>
		public EventArgsAdapter() :
			this(new EventArgs())
		{
		}

		/// <summary>
		/// Initializes new instance of <see cref="EventArgsAdapter"/>.
		/// </summary>
		/// <param name="args">EventArgs to be used by the adapter</param>
		public EventArgsAdapter(EventArgs args)
		{
			if (args == null)
				throw new ArgumentNullException(nameof(args));

			_args = args;
		}
	}
}