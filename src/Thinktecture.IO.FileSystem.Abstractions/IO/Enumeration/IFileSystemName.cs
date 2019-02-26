#if NETCOREAPP2_2

using System;
using JetBrains.Annotations;
using Thinktecture.IO.Enumeration.Adapters;

namespace Thinktecture.IO.Enumeration
{
	/// <summary>
	/// Provides methods for matching file system names.
	/// </summary>
	public interface IFileSystemName
	{
		/// <summary>
		/// Change '*' and '?' to '&lt;', '&gt;' and '"' to match Win32 behavior. For compatibility, Windows
		/// changes some wildcards to provide a closer match to historical DOS 8.3 filename matching.
		/// </summary>
		string TranslateWin32Expression([CanBeNull] string expression);

		/// <summary>
		/// Return true if the given expression matches the given name. Supports the following wildcards:
		/// '*', '?', '&lt;', '&gt;', '"'. The backslash character '\' escapes.
		/// </summary>
		/// <param name="expression">The expression to match with, such as "*.foo".</param>
		/// <param name="name">The name to check against the expression.</param>
		/// <param name="ignoreCase">True to ignore case (default).</param>
		/// <remarks>
		/// This is based off of System.IO.PatternMatcher used in FileSystemWatcher, which is based off
		/// of RtlIsNameInExpression, which defines the rules for matching DOS wildcards ('*', '?', '&lt;', '&gt;', '"').
		///
		/// Like PatternMatcher, matching will not line up with Win32 behavior unless you transform the expression
		/// using <see cref="FileSystemNameAdapter.TranslateWin32Expression"/>
		/// </remarks>
		bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true);

		/// <summary>
		/// Return true if the given expression matches the given name. '*' and '?' are wildcards, '\' escapes.
		/// </summary>
		bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true);
	}
}

#endif
