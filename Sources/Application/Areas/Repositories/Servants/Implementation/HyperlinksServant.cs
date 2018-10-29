using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlh.WordAccess.Areas.Models;
using nat = Microsoft.Office.Interop.Word;

namespace Mmu.Mlh.WordAccess.Areas.Repositories.Servants.Implementation
{
    internal class HyperlinksServant : IHyperlinksServant
    {
        public async Task<IReadOnlyCollection<Hyperlink>> GetHyperLinksAsync(nat.Document nativeDocument)
        {
            return await Task.Run(
                () =>
                {
                    return nativeDocument
                        .Hyperlinks
                        .Cast<nat.Hyperlink>()
                        .Where(hyperLink => !string.IsNullOrEmpty(hyperLink.Address))
                        .Select(hyperLink => hyperLink.Address)
                        .Select(str => new Uri(str))
                        .Select(uri => new Hyperlink(uri))
                        .ToList();
                });
        }
    }
}