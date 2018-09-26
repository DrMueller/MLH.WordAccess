using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants.Implementation
{
    internal class WordDocumentShapesServant : IWordDocumentShapesServant
    {
        private readonly IWordDocumentTextServant _textServant;

        public WordDocumentShapesServant(IWordDocumentTextServant textServant)
        {
            _textServant = textServant;
        }

        public async Task<IReadOnlyCollection<Models.Shape>> GetShapesAsync(Document nativeDocument)
        {
            var result = new List<Models.Shape>();

            await System.Threading.Tasks.Task.Run(
                () =>
                {
                    foreach (InlineShape shape in nativeDocument.InlineShapes)
                    {
                        var captionText = _textServant.GetNextSentenceText(nativeDocument, shape.Range);
                        result.Add(new Models.Shape(captionText));
                    }
                });

            return result;
        }
    }
}