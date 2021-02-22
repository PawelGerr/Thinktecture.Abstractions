using System;
using System.ComponentModel;
using Thinktecture.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>Provides data for the <see cref="E:System.Console.CancelKeyPress"></see> event. This class cannot be inherited.</summary>
	public class ConsoleCancelEventArgsAdapter : EventArgsAdapter, IConsoleCancelEventArgs
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new ConsoleCancelEventArgs UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		protected new ConsoleCancelEventArgs Implementation { get; }

		/// <inheritdoc />
		public bool Cancel
		{
			get => Implementation.Cancel;
			set => Implementation.Cancel = value;
		}

		/// <inheritdoc />
		public ConsoleSpecialKey SpecialKey => Implementation.SpecialKey;

		/// <summary>
		/// Initializes a new instance of <see cref="ConsoleCancelEventArgsAdapter"/>.
		/// </summary>
		/// <param name="eventArgs">Event args to use.</param>
		public ConsoleCancelEventArgsAdapter(ConsoleCancelEventArgs eventArgs)
		{
			Implementation = eventArgs ?? throw new ArgumentNullException(nameof(eventArgs));
		}
	}
}
