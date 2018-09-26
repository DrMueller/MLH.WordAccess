using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Mmu.Mlh.WordAccess.Areas.Models;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants
{
    internal interface IWordDocumentWordsServant
    {
        Task<IReadOnlyCollection<Word>> GetWordsAsync(Document nativeDocument);
    }
}