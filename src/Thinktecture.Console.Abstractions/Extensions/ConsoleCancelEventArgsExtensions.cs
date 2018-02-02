using System;
using System.IO;
using JetBrains.Annotations;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="ConsoleCancelEventArgs"/>.
	/// </summary>
	public static class BufferedStreamExtensions
	{
		/// <summary>
		/// Converts provided eventArgs to <see cref="IConsoleCancelEventArgs"/>;
		/// </summary>
		/// <param name="eventArgs">Event args to convert.</param>
		/// <returns>Converted event args.</returns>
		[CanBeNull]
		public static IConsoleCancelEventArgs ToInterface([CanBeNull] this ConsoleCancelEventArgs eventArgs)
		{
			return (eventArgs == null) ? null : new ConsoleCancelEventArgsAdapter(eventArgs);
		}

		/// <summary>
		/// Converts provided <see cref="IConsoleCancelEventArgs"/> info to <see cref="ConsoleCancelEventArgs"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IConsoleCancelEventArgs"/> to convert.</param>
		/// <returns>An instance of <see cref="ConsoleCancelEventArgs"/>.</returns>
		[CanBeNull]
		public static ConsoleCancelEventArgs ToImplementation([CanBeNull] this IConsoleCancelEventArgs abstraction)
		{
			return ((IAbstraction<ConsoleCancelEventArgs>)abstraction)?.UnsafeConvert();
		}
	}
}
