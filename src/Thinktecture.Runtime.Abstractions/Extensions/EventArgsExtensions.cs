using System;
using Thinktecture.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="EventArgs"/>.
	/// </summary>
	public static class EventArgsExtensions
	{
		/// <summary>
		/// Converts provided <see cref="EventArgs"/> to <see cref="IEventArgs"/>.
		/// </summary>
		/// <param name="args"><see cref="EventArgs"/> to convert.</param>
		/// <returns>An instance of <see cref="IEventArgs"/>.</returns>
		public static IEventArgs ToInterface(this EventArgs args)
		{
			return (args == null) ? null : new EventArgsAdapter(args);
		}

		/// <summary>
		/// Converts provided <see cref="IEventArgs"/> to <see cref="EventArgs"/>.
		/// </summary>
		/// <param name="args"><see cref="IEventArgs"/> to convert.</param>
		/// <returns>An instance of <see cref="EventArgs"/>.</returns>
		public static EventArgs ToImplementation(this IEventArgs args)
		{
			return args?.UnsafeConvert();
		}
	}
}