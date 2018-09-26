using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using Mmu.Mlh.WordAccess.Areas.Models;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants.Implementation
{
    internal class WordDocumentWordsServant : IWordDocumentWordsServant
    {
        private readonly IWordDocumentTextServant _textServant;

        public WordDocumentWordsServant(IWordDocumentTextServant textServant)
        {
            _textServant = textServant;
        }

        public async Task<IReadOnlyCollection<Word>> GetWordsAsync(Document nativeDocument)
        {
            var words = new ConcurrentBag<Word>();

            await System.Threading.Tasks.Task.Run(
                () =>
                {
                    Parallel.ForEach(
                        nativeDocument.Content.Words.Cast<Range>(),
                        nativeWord =>
                        {
                            var trimmedText = _textServant.GetTrimmedText(nativeWord);
                            if (!string.IsNullOrEmpty(trimmedText))
                            {
                                var font = new Models.Font(nativeWord.Font.Name, nativeWord.Font.Size);
                                words.Add(new Word(nativeWord.Start, trimmedText, font));
                            }
                        });
                });

            var sortedWords = words.OrderBy(word => word.StartPosition).ToList();
            return sortedWords;
        }
    }
}