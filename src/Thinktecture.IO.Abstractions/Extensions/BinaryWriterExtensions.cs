using System;
using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="BinaryWriter"/>.
	/// </summary>
	public static class BinaryWriterExtensions
	{
		/// <summary>
		/// Converts provided writer to <see cref="IBinaryWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static IBinaryWriter ToInterface(this BinaryWriter writer)
		{
			return (writer == null) ? null : new BinaryWriterAdapter(writer);
		}
		
		/// <summary>
		/// Converts provided writer to <see cref="BinaryWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static BinaryWriter ToImplementation(this IBinaryWriter writer)
		{
			return writer?.InternalInstance;
		}
	}
}