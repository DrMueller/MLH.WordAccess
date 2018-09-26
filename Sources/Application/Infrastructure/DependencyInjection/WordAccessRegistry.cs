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
            For<IWordDocumentHyperlinksServant>().Use<WordDocumentHyperlinksServant>().Singleton();
            For<IWordDocumentShapesServant>().Use<WordDocumentShapesServant>().Singleton();
            For<IWordDocumentTablesServant>().Use<WordDocumentTablesServant>().Singleton();
            For<IWordDocumentTextServant>().Use<WordDocumentTextServant>().Singleton();
            For<IWordDocumentWordsServant>().Use<WordDocumentWordsServant>().Singleton();
        }
    }
}