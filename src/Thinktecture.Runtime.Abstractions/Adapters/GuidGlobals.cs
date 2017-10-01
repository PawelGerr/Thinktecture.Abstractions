using System;

namespace Thinktecture.Adapters
{
	/// <summary>
	/// Statics of <see cref="Guid"/>
	/// </summary>
	public class GuidGlobals : IGuidGlobals
	{
		/// <inheritdoc />
		public Guid Empty { get; }

		/// <summary>
		/// Initializes new instance of <see cref="GuidGlobals"/>.
		/// </summary>
		public GuidGlobals()
		{
			Empty = Guid.Empty;
		}

		/// <inheritdoc />
		public Guid NewGuid()
		{
			return Guid.NewGuid();
		}

		/// <inheritdoc />
		public Guid Parse(string input)
		{
			return Guid.Parse(input);
		}

		/// <inheritdoc />
		public Guid ParseExact(string input, string format)
		{
			return Guid.ParseExact(input, format);
		}

		/// <inheritdoc />
		public bool TryParse(string input, out Guid result)
		{
			return Guid.TryParse(input, out result);
		}

		/// <inheritdoc />
		public bool TryParseExact(string input, string format, out Guid result)
		{
			return Guid.TryParseExact(input, format, out result);
		}
	}
}
