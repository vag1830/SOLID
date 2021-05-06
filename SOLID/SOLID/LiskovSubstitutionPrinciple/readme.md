### *L* - Liskov's Substitution Principle (*LSP*)

##### History

Barbara Liskov introduced the term in her conference keynote “Data abstraction” in 1987. 
A few years later, she published a paper with Jeanette Wing in which they defined the 
principle as: 

> Let Φ(x) be a property provable about objects x of type T

##### Definition

Barbara Liskov also wrote the following as a way to define subtypes

> What is wanted here is something like the following substitution property: 
> If for each object o1 of type S there is an object o2 of type T such that for all
> programs P defined in terms of T, the behavior of P is unchanged when o1 is 
> substituted for o2 then S is a subType of T.

The above is not so easy to understand. I think it describes this 

```C#
// T
class Base {
	public Do() {}
}

// S
class Sub : Base {
	public override Do() {}
}

// P
class Program {
	DoSomething(Base obj) {
		obj.Do();
	}
}

// The below should behave the same way.
program.DoSomething(new Sub());
program.DoSomething(new Base());

```
	
LSP states that derived classes should be able to extend their base classes without 
changing their behavior.


#### Before the Examples... :)

A violation can have dramatic impact. It might be detected late making it very difficult to fix.

**Difficult to protect against a violation.**

Unfortunately, there is no easy way to enforce this principle. 
The compiler only checks the structural rules defined the language, but it can’t enforce a specific behavior.

Implement own checks to ensure that the code does not violate the Liskov Substitution Principle.
Code reviews and unit tests can help a lot. 

In any case being aware of this principle and the problems a violation might cause is a good start.

#### Examples...
