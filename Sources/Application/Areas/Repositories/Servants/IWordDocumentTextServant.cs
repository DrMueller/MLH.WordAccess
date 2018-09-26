using Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants
{
    internal interface IWordDocumentTextServant
    {
        string GetNextSentenceText(Document document, Range range);

        string GetTrimmedText(Range range);
    }
}