using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.WordAccess.Areas.Models;
using nat = Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants.Implementation
{
    internal class WordDocumentTablesServant : IWordDocumentTablesServant
    {
        private readonly IWordDocumentTextServant _textServant;

        public WordDocumentTablesServant(IWordDocumentTextServant textServant)
        {
            _textServant = textServant;
        }

        public async Task<IReadOnlyCollection<Table>> GetTablesAsync(nat.Document nativeDocument)
        {
            return await Task.Run(
                () =>
                {
                    return nativeDocument.Tables.Cast<nat.Table>()
                        .Select(nativeTable => CreateFromNativeTable(nativeDocument, nativeTable))
                        .ToList();
                });
        }

        private Table CreateFromNativeTable(nat.Document nativeDocument, nat.Table nativeTable)
        {
            var cells = nativeTable.Range.Cells.Cast<nat.Cell>()
                .Select(
                    nativeCell =>
                        new Cell(nativeCell.ColumnIndex, nativeCell.RowIndex, _textServant.GetTrimmedText(nativeCell.Range)))
                .ToList();

            var captionText = _textServant.GetNextSentenceText(nativeDocument, nativeTable.Range);

            return new Table(captionText, cells);
        }
    }
}