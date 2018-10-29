namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Shape : IElementWithCaption
    {
        public Shape(Characters caption)
        {
            Caption = caption;
        }

        public Characters Caption { get; }
    }
}