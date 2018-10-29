using System.Collections.Generic;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Table : IElementWithCaption
    {
        public Characters Caption { get; }
        public IReadOnlyCollection<Cell> Cells { get; }

        public Table(Characters caption, IReadOnlyCollection<Cell> cells)
        {
            Guard.ObjectNotNull(() => caption);
            Guard.ObjectNotNull(() => cells);

            Caption = caption;
            Cells = cells;
        }
    }
}