using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IO
{
	public class StringWriterAdapter : TextWriterAdapter, IStringWriter
	{
		private readonly StringWriter _writer;

		public StringWriterAdapter(StringWriter writer) : base(writer)
		{
			if (writer == null)
				throw new ArgumentNullException(nameof(writer));

			_writer = writer;
		}

		/// <inheritdoc />
		StringWriter IStringWriter.ToImplementation()
		{
			return _writer;
		}

		/// <inheritdoc />
		public StringBuilder GetStringBuilder()
		{
			return _writer.GetStringBuilder();
		}
	}
}