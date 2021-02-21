using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using Thinktecture.IO.Adapters;

namespace Thinktecture.CodeDom.Compiler.Adapters
{
   /// <summary>Provides a text writer that can indent new lines by a tab string token.</summary>
   public class IndentedTextWriterAdapter : TextWriterAdapter, IIndentedTextWriter
   {
      /// <inheritdoc />
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new IndentedTextWriter UnsafeConvert()
      {
         return Implementation;
      }

      /// <summary>
      /// Implementation used by the adapter.
      /// </summary>
      protected new IndentedTextWriter Implementation { get; }

      /// <summary>Specifies the default tab string. This field is constant. </summary>
      // ReSharper disable once InconsistentNaming
      public const string DefaultTabString = IndentedTextWriter.DefaultTabString;

      /// <inheritdoc />
      public int Indent
      {
         get => Implementation.Indent;
         set => Implementation.Indent = value;
      }

      /// <inheritdoc />
      public TextWriter InnerWriter => Implementation.InnerWriter;

      /// <summary>Initializes a new instance of the <see cref="IndentedTextWriterAdapter" /> class using the specified text writer and default tab string.</summary>
      /// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to use for output. </param>
      public IndentedTextWriterAdapter(TextWriter writer)
         : this(new IndentedTextWriter(writer))
      {
      }

      /// <summary>Initializes a new instance of the <see cref="IndentedTextWriterAdapter" /> class using the specified text writer and tab string.</summary>
      /// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to use for output. </param>
      /// <param name="tabString">The tab string to use for indentation. </param>
      public IndentedTextWriterAdapter(TextWriter writer, string tabString)
         : this(new IndentedTextWriter(writer, tabString))
      {
      }

      /// <summary>
      /// Initializes a new instance of <see cref="IndentedTextWriterAdapter"/>.
      /// </summary>
      /// <param name="writer">Writer to be used by the adapter.</param>
      public IndentedTextWriterAdapter(IndentedTextWriter writer)
         : base(writer)
      {
         Implementation = writer;
      }

      /// <inheritdoc />
      public void WriteLineNoTabs(string s)
      {
         Implementation.WriteLineNoTabs(s);
      }
   }
}
