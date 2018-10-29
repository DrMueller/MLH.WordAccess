using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants
{
    internal interface IHyperlinksServant
    {
        Task<IReadOnlyCollection<Models.Hyperlink>> GetHyperLinksAsync(Document nativeDocument);
    }
}