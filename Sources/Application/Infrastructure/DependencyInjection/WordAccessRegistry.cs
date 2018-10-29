using Mmu.Mlh.WordAccess.Areas.Repositories;
using Mmu.Mlh.WordAccess.Areas.Repositories.Implementation;
using Mmu.Mlh.WordAccess.Areas.Repositories.Servants;
using Mmu.Mlh.WordAccess.Areas.Repositories.Servants.Implementation;
using StructureMap;

namespace Mmu.Mlh.WordAccess.Infrastructure.DependencyInjection
{
    public class WordAccessRegistry : Registry
    {
        public WordAccessRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<WordAccessRegistry>();
                    scanner.WithDefaultConventions();
                });

            For<IWordDocumentRepository>().Use<WordDocumentRepository>().Singleton();
            For<IHyperlinksServant>().Use<HyperlinksServant>().Singleton();
            For<IShapesServant>().Use<ShapesServant>().Singleton();
            For<ITablesServant>().Use<TablesServant>().Singleton();
            For<ITextServant>().Use<TextServant>().Singleton();
            For<ICharactersServant>().Use<WordDocumentWordsServant>().Singleton();
        }
    }
}