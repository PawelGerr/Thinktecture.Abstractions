using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using JetBrains.Annotations;
using Thinktecture.Text;

// ReSharper disable AssignNullToNotNullAttribute

namespace Thinktecture.IO.Adapters
{
	/// <summary>
	/// Adapter for <see cref="StringWriter"/>.
	/// </summary>
	public class StringWriterAdapter : TextWriterAdapter, IStringWriter
	{
		/// <inheritdoc />
		[NotNull]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new StringWriter UnsafeConvert()
		{
			return Implementation;
		}

		/// <summary>
		/// Implementation used by the adapter.
		/// </summary>
		[NotNull]
		protected new StringWriter Implementation { get; }

		/// <summary>Initializes a new instance of the <see cref="StringWriterAdapter" /> class.</summary>
		public StringWriterAdapter()
			: this(new StringWriter())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringWriterAdapter" /> class with the specified format control.</summary>
		/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
		public StringWriterAdapter([CanBeNull] IFormatProvider formatProvider)
			: this(new StringWriter(formatProvider))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringWriterAdapter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <param name="sb">The StringBuilder to write to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="sb" /> is null. </exception>
		public StringWriterAdapter([NotNull] IStringBuilder sb)
			: this(sb.ToImplementation())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringWriterAdapter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <param name="sb">The StringBuilder to write to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="sb" /> is null. </exception>
		public StringWriterAdapter([NotNull] StringBuilder sb)
			: this(new StringWriter(sb))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringWriterAdapter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" /> and has the specified format provider.</summary>
		/// <param name="sb">The StringBuilder to write to. </param>
		/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="sb" /> is null. </exception>
		public StringWriterAdapter([NotNull] IStringBuilder sb, [CanBeNull] IFormatProvider formatProvider)
			: this(sb.ToImplementation(), formatProvider)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="StringWriterAdapter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" /> and has the specified format provider.</summary>
		/// <param name="sb">The StringBuilder to write to. </param>
		/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
		/// <exception cref="T:System.ArgumentNullException">
		/// <paramref name="sb" /> is null. </exception>
		public StringWriterAdapter([NotNull] StringBuilder sb, [CanBeNull] IFormatProvider formatProvider)
			: this(new StringWriter(sb, formatProvider))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StringWriterAdapter" /> class.
		/// </summary>
		/// <param name="writer">Writer to be used by the adapter.</param>
		public StringWriterAdapter([NotNull] StringWriter writer)
			: base(writer)
		{
			Implementation = writer ?? throw new ArgumentNullException(nameof(writer));
		}

		/// <inheritdoc />
		public IStringBuilder GetStringBuilder()
		{
			return Implementation.GetStringBuilder().ToInterface();
		}
	}
}
