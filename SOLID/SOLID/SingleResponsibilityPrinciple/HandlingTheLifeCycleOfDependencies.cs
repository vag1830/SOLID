using System.Collections.Generic;
using System.Linq;

namespace SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    ///     This module has multiple responsibilities.
    ///     It needs to know and create an instance of ItemRepository.
    ///     In addition to that and because of that it needs to know the internal dependencies of ItemRepository.
    ///     One more responsibility which is not obvious, is that this module also handles the lifecycle of ItemRepository and all of it's dependencies.
    ///
    ///     Id we look at the SRP principal then this module has multiple reasons to change.
    ///
    ///     The first one is straight forward and it has to do with what this module actually does. In this case, it trims the items before it returns them.
    ///     If this requirement changes then we will have to change that part of the code.
    ///
    ///     The second and not so obvious is in regards to ItemRepository. Imagine the ItemRepository changes in the way that now it has one more dependency.
    ///     Then this module needs to be adapted to accomodate that. Imagine that at scale. Imagine a large number of modules depend on ItemRepository.
    ///     All of them will need to adapt.
    ///
    ///     Solution:
    ///     Use and Interface. An interface abstracts away internal implementation details.
    ///     Use DI. DI abstract away details related to the lifecycle of a Module.
    ///     Is it a sigleton or a scoped instance? This module does not really need to know that detail.
    /// </summary>
    public class HandlingTheLifeCycleOfDependencies
    {
        public IList<string> GetAllItems()
        {
            var itemRepositoryInternalDependency = new Dependency();
            var itemsRepository = new ItemRepository(itemRepositoryInternalDependency);

            var items = itemsRepository.GetAllItems();

            return items
                .Select(item => item.Trim())
                .ToList();
        }
    }

    public class ItemRepository
    {
        private readonly Dependency _dependency;

        public ItemRepository(Dependency dependency)
        {
            _dependency = dependency;
        }

        public IList<string> GetAllItems()
        {
            return new List<string>();
        }
    }

    public class Dependency
    {

    }
}
