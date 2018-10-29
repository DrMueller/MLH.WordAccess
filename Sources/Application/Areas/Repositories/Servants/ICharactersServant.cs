using System.Threading.Tasks;
using Mmu.Mlh.WordAccess.Areas.Models;
using n = Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants
{
    internal interface ICharactersServant
    {
        Task<Characters> GetCharactersAsync(n.Document nativeDocument);
    }
}