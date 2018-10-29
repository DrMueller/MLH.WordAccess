using Mmu.Mlh.DomainExtensions.Areas.DomainModeling;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Font : ValueObject<Font>
    {
        public string Name { get; }
        public double Size { get; }

        public Font(string name, double size)
        {
            Guard.StringNotNullOrEmpty(() => name);
            Name = name;
            Size = size;
        }
    }
}