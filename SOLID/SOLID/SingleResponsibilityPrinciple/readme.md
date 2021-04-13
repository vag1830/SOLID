### *S* - Single Responsibility Principle (known as SRP)

##### History

	The term was introduced by Robert C. Martin in an article by the same name, 
	as part of his Principles of Object Oriented Design, made popular by his book  
	Agile Software Development, Principles, Patterns, and Practices.

##### Definition

1. > The best structure for a software system is heavily 
   > influenced by the social structure of the organization so that 
   > each software module has one, and only one, reason to change.
2. > A module should have one, and only one, reason to change.
3. > A module should be responsible to one, and only one, actor.


###### I ask myself:
* Is this module responsible to do what this piece of code does?
If the piece of code performs a calculation. 
Is this class responsible to perform this calculation or should it depend to an other module which would be responsible for it?

* Is this module responsible to know the information required to perform this task?
If this module is responsible for a decision based on some information or state, 
then should this module generate this information or should the caller provide the information?

* What is this module really responsible for? 
Look at the name of the module. Does it describle exactly what the module does ?

#### Examples...
