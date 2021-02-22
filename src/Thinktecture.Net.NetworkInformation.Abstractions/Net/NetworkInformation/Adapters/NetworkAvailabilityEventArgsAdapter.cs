using System.ComponentModel;
using System.Net.NetworkInformation;
using Thinktecture.Adapters;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>Provides data for the <see cref="INetworkChange.NetworkAvailabilityChanged" /> event.</summary>
	public class NetworkAvailabilityEventArgsAdapter : EventArgsAdapter, INetworkAvailabilityEventArgs
	{
		/// <inheritdoc />
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new NetworkAvailabilityEventArgs UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		protected new NetworkAvailabilityEventArgs Implementation { get; }

		/// <inheritdoc />
		public bool IsAvailable => Implementation.IsAvailable;

		/// <summary>
		/// Initializes new instance of <see cref="NetworkAvailabilityEventArgsAdapter"/>.
		/// </summary>
		/// <param name="args">Event args to use by the adapter.</param>
		public NetworkAvailabilityEventArgsAdapter(NetworkAvailabilityEventArgs args)
			: base(args)
		{
			Implementation = args;
		}
	}
}
