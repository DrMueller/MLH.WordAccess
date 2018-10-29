using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Mmu.Mlh.WordAccess.Areas.Models;
using Mmu.Mlh.WordAccess.Areas.Repositories.Servants;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Implementation
{
    internal class WordDocumentRepository : IWordDocumentRepository
    {
        private readonly IHyperlinksServant _hyperlinksServant;
        private readonly IShapesServant _shapesServant;
        private readonly ITablesServant _tablesServant;
        private readonly ICharactersServant _wordsServant;

        public WordDocumentRepository(
            IShapesServant shapesServant,
            ITablesServant tablesServant,
            ICharactersServant wordsServant,
            IHyperlinksServant hyperlinksServant)
        {
            _shapesServant = shapesServant;
            _tablesServant = tablesServant;
            _wordsServant = wordsServant;
            _hyperlinksServant = hyperlinksServant;
        }

        public Task<WordDocument> LoadAsync(string filePath)
        {
            return System.Threading.Tasks.Task.Run(
                async () =>
                {
                    Application app = null;
                    try
                    {
                        app = new Application();
                        var nativeDocument = app.Documents.Open(filePath);
                        var words = await _wordsServant.GetCharactersAsync(nativeDocument);
                        var tables = await _tablesServant.GetTablesAsync(nativeDocument);
                        var shapes = await _shapesServant.GetShapesAsync(nativeDocument);
                        var hyperlinks = await _hyperlinksServant.GetHyperLinksAsync(nativeDocument);

                        return new WordDocument(words, tables, shapes, hyperlinks);
                    }
                    finally
                    {
                        if (app != null)
                        {
                            Marshal.ReleaseComObject(app);
                        }
                    }
                });
        }
    }
}