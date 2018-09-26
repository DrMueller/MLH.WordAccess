using System;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Hyperlink
    {
        public Uri Address { get; }

        public Hyperlink(Uri address)
        {
            Guard.ObjectNotNull(() => address);

            Address = address;
        }
    }
}