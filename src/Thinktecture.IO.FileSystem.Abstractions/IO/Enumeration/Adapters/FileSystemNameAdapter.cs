using System;
using System.IO.Enumeration;

namespace Thinktecture.IO.Enumeration.Adapters
{
	/// <summary>
	/// Provides methods for matching file system names.
	/// </summary>
	public class FileSystemNameAdapter : IFileSystemName
	{
		/// <inheritdoc />
		public string TranslateWin32Expression(string? expression)
		{
			return FileSystemName.TranslateWin32Expression(expression);
		}

		/// <inheritdoc />
		public bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			return FileSystemName.MatchesWin32Expression(expression, name, ignoreCase);
		}

		/// <inheritdoc />
		public bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
		{
			return FileSystemName.MatchesSimpleExpression(expression, name, ignoreCase);
		}
	}
}
