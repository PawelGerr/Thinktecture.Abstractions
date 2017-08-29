#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using JetBrains.Annotations;
using Thinktecture.Net.NetworkInformation;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for arrays.
	/// </summary>
	public static class ArrayExtensions
	{
		/// <summary>
		/// Converts an array of <see cref="NetworkInterface"/> to an array of <see cref="INetworkInterface"/>.
		/// </summary>
		/// <param name="elements">Array to convert.</param>
		/// <returns>An array of <see cref="INetworkInterface"/>.</returns>
		[CanBeNull]
		public static INetworkInterface[] ToInterface([CanBeNull] this NetworkInterface[] elements)
		{
			if (elements == null)
				return null;

			var abstractions = new INetworkInterface[elements.Length];

			for (var i = 0; i < elements.Length; i++)
			{
				abstractions[i] = elements[i].ToInterface();
			}

			return abstractions;
		}
	}
}

#endif
