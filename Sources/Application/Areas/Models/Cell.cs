using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Cell
    {
        public int ColumnIndex { get; }
        public int RowIndex { get; }
        public string Value { get; }

        public Cell(int columnIndex, int rowIndex, string value)
        {
            Guard.StringNotNullOrEmpty(() => value);

            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
            Value = value;
        }
    }
}