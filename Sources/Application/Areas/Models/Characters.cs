using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Mlh.WordAccess.Areas.Models
{
    public class Characters
    {
        public IReadOnlyCollection<Character> Entries { get; }

        public Characters(IReadOnlyCollection<Character> entries)
        {
            Guard.ObjectNotNull(() => entries);
            Entries = entries;
        }
    }
}
