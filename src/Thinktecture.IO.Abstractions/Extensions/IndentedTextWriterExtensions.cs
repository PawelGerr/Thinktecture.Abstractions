#if NET45 || NET462 || NETSTANDARD2_0

using System.CodeDom.Compiler;
using JetBrains.Annotations;
using Thinktecture.CodeDom.Compiler;
using Thinktecture.CodeDom.Compiler.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="IndentedTextWriter"/>.
	/// </summary>
	public static class IndentedTextWriterExtensions
	{
		/// <summary>
		/// Converts provided reader to <see cref="IIndentedTextWriter"/>.
		/// </summary>
		/// <param name="reader">Reader to convert</param>
		/// <returns>Converted reader.</returns>
		[CanBeNull]
		public static IIndentedTextWriter ToInterface([CanBeNull] this IndentedTextWriter reader)
		{
			if (reader == null)
				return null;

			return new IndentedTextWriterAdapter(reader);
		}

		/// <summary>
		/// Converts provided <see cref="IIndentedTextWriter"/> info to <see cref="IndentedTextWriter"/>.
		/// </summary>
		/// <param name="abstraction">Instance of <see cref="IIndentedTextWriter"/> to convert.</param>
		/// <returns>An instance of <see cref="IndentedTextWriter"/>.</returns>
		[CanBeNull]
		public static IndentedTextWriter ToImplementation([CanBeNull] this IIndentedTextWriter abstraction)
		{
			return ((IAbstraction<IndentedTextWriter>)abstraction)?.UnsafeConvert();
		}
	}
}

#endif
