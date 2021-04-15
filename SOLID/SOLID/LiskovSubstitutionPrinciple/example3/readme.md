#### Example 2 

Returning a value of a type that has restrictions that are unknown from the method's signature. 
Such as returning a value of type ReadOnlyCollection from a derived class' method while
the return type in its signature is ICollection. The code below demonstrates how this 
approach is making unexpected behavior for the code consumer.


Essentially either the interface is not descriptive enough or the implementation of it violates LSP