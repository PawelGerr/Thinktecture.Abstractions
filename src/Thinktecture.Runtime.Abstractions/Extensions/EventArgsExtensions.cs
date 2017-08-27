using System;
using Thinktecture.Adapters;

// ReSharper disable once CheckNamespace
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
	}
}
