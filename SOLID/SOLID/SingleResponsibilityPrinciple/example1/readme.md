#### Example 1

###### TheBadModule

- [ ] *can you find multiple reasons for this module to change ?*

* The first one is straight forward and it has to do with what this module actually does. 
In this case, it trims the items before it returns them.
If this requirement changes then we will have to change that part of the code.

* The second and not so obvious is in regards to ItemRepository. Imagine the ItemRepository changes in the way that now it has one more dependency.
Then this module needs to be adapted to accomodate that. Imagine that at scale. Imagine a large number of modules depend on ItemRepository.
All of them will need to adapt.

- [ ] *why does it have multiple responsibilities ?*

* It needs to know and create an instance of Repository.
* In addition to that and because of that it needs to know the internal dependencies of Repository.
* One more responsibility which is not obvious, is that this module also handles the lifecycle of 
Repository and all of it's dependencies.
   
###### TheGoodModule

* Use DI. DI abstract away details related to the lifecycle of a Module. 
Is it a sigleton or a scoped instance? This module does not really need to know that detail.

###### TheEvenBetterModule

* Use an Interface. An interface abstracts away implementation details.
