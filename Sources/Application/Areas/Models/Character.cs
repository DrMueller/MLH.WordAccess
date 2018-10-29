using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Character
    {
        public string CharacterRepresentation { get; }
        public Font Font { get; }
        public int Position { get; }

        public Character(Font font, int position, string characterRepresentation)
        {
            Guard.ObjectNotNull(() => font);

            Font = font;
            Position = position;
            CharacterRepresentation = characterRepresentation;
        }
    }
}