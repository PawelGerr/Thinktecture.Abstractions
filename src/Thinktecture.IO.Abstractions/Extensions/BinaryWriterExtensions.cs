using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
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