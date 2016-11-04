using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public static class BinaryReaderExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IBinaryReader"/>.
		/// </summary>
		/// <param name="reader">Reader to convert.</param>
		/// <returns>Converted reader.</returns>
		public static IBinaryReader ToInterface(this BinaryReader reader)
		{
			return new BinaryReaderAdapter(reader);
		}
	}
}