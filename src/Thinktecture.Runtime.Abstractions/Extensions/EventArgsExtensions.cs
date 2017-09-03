using System;
using JetBrains.Annotations;
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
		[CanBeNull]
		public static IEventArgs ToInterface([CanBeNull] this EventArgs args)
		{
			if (args == null)
				return null;

			if (ReferenceEquals(args, EventArgs.Empty))
				return EventArgsAdapter.Empty;

			return new EventArgsAdapter(args);
		}
	}
}
