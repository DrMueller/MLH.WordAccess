namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Shape : IElementWithCaption
    {
        public string CaptionText { get; }

        public Shape(string captionText)
        {
            CaptionText = captionText;
        }
    }
}