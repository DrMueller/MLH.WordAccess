using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants.Implementation
{
    internal class WordDocumentTextServant : IWordDocumentTextServant
    {
        public string GetNextSentenceText(Document document, Range range)
        {
            var sentences = document.Range(range.End, range.End + 500).Sentences;
            var ignoredSentences = new List<string>
            {
                "\v/\r",
                "/\r"
            };

            foreach (Range sentence in sentences)
            {
                if (!string.IsNullOrEmpty(sentence.Text) && !ignoredSentences.Contains(sentence.Text))
                {
                    return sentence.Text.Trim().Replace(Environment.NewLine, string.Empty);
                }
            }

            return string.Empty;
        }

        public string GetTrimmedText(Range range)
        {
            var text = range.Text?.Trim();
            text = text?.Replace("\r\a", string.Empty);

            return text;
        }
    }
}