using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants
{
    internal interface IShapesServant
    {
        Task<IReadOnlyCollection<Models.Shape>> GetShapesAsync(Document nativeDocument);
    }
}