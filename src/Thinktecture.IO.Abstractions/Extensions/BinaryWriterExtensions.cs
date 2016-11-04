using System.IO;
using Thinktecture.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture
{
	public static class BinaryWriterExtensions
	{
		/// <summary>
		/// Converts provided writer to <see cref="IBinaryWriter"/>.
		/// </summary>
		/// <param name="writer">Writer to convert.</param>
		/// <returns>Converted writer.</returns>
		public static IBinaryWriter ToInterface(this BinaryWriter writer)
		{
			return new BinaryWriterAdapter(writer);
		}
	}
}