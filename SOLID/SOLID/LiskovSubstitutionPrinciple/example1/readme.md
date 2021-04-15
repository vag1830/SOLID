#### Example 1

The classic example is the Rectangle/Square violation.

A violation can have dramatic impact. It might be detected late making difficult to fix.

**Difficult to protect against a violation.**

Unfortunately, there is no easy way to enforce this principle. 
The compiler only checks the structural rules defined the language, but it can’t enforce a specific behavior.

Implement own checks to ensure that the code does not violate the Liskov Substitution Principle.
Code reviews and unit tests can help a lot. 

In any case being aware of this principle and the problems a violation might cause is a good start.
