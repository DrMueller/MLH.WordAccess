using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Word
    {
        public Font Font { get; }
        public int StartPosition { get; }
        public string Text { get; }

        public Word(int startPosition, string text, Font font)
        {
            Guard.ObjectNotNull(() => font);

            StartPosition = startPosition;
            Text = text;
            Font = font;
        }
    }
}