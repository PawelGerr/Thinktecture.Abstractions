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

#if NETCOREAPP2_1
		/// <inheritdoc />
		public Guid Parse(ReadOnlySpan<char> input)
		{
			return Guid.Parse(input);
		}

		/// <inheritdoc />
		public bool TryParse(ReadOnlySpan<char> input, out Guid result)
		{
			return Guid.TryParse(input, out result);
		}

		/// <inheritdoc />
		public Guid ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format)
		{
			return Guid.ParseExact(input, format);
		}

		/// <inheritdoc />
		public bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result)
		{
			return Guid.TryParseExact(input, format, out result);
		}
#endif

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
