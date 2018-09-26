using System.Collections.Generic;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Table : IElementWithCaption
    {
        public string CaptionText { get; }
        public IReadOnlyCollection<Cell> Cells { get; }

        public Table(string captionText, IReadOnlyCollection<Cell> cells)
        {
            Guard.ObjectNotNull(() => cells);

            CaptionText = captionText;
            Cells = cells;
        }
    }
}