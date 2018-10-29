using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Cell
    {
        public int ColumnIndex { get; }
        public int RowIndex { get; }
        public Characters Value { get; }

        public Cell(int columnIndex, int rowIndex, Characters value)
        {
            Guard.ObjectNotNull(() => value);

            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
            Value = value;
        }
    }
}