using System.Collections.Generic;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class WordDocument
    {
        public IReadOnlyCollection<Hyperlink> HyperLinks { get; }
        public IReadOnlyCollection<Shape> Shapes { get; }
        public Characters Text { get; }
        public IReadOnlyCollection<Table> Tables { get; }

        public WordDocument(
            Characters text,
            IReadOnlyCollection<Table> tables,
            IReadOnlyCollection<Shape> shapes,
            IReadOnlyCollection<Hyperlink> hyperLinks
        )
        {
            Guard.ObjectNotNull(() => text);
            Guard.ObjectNotNull(() => tables);
            Guard.ObjectNotNull(() => shapes);
            Guard.ObjectNotNull(() => hyperLinks);

            Text = text;
            Tables = tables;
            Shapes = shapes;
            HyperLinks = hyperLinks;
        }
    }
}