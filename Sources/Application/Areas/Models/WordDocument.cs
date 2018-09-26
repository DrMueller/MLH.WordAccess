using System.Collections.Generic;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class WordDocument
    {
        public IReadOnlyCollection<Hyperlink> HyperLinks { get; }
        public IReadOnlyCollection<Shape> Shapes { get; }
        public IReadOnlyCollection<Table> Tables { get; }
        public IReadOnlyCollection<Word> Words { get; }

        public WordDocument(
            IReadOnlyCollection<Word> words,
            IReadOnlyCollection<Table> tables,
            IReadOnlyCollection<Shape> shapes,
            IReadOnlyCollection<Hyperlink> hyperLinks
        )
        {
            Guard.ObjectNotNull(() => words);
            Guard.ObjectNotNull(() => tables);
            Guard.ObjectNotNull(() => shapes);
            Guard.ObjectNotNull(() => hyperLinks);

            Words = words;
            Tables = tables;
            Shapes = shapes;
            HyperLinks = hyperLinks;
        }
    }
}