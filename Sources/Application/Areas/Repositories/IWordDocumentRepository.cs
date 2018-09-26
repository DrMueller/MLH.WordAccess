using System.Threading.Tasks;
using Mmu.Mlh.WordAccess.Areas.Models;

namespace Mmu.Mlh.WordAccess.Areas.Repositories
{
    public interface IWordDocumentRepository
    {
        Task<WordDocument> LoadAsync(string filePath);
    }
}