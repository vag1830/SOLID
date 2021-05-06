#### Example 2 

Returning a value of a type that has restrictions that are unknown from the method's signature. 

Example: returning a value of type `ReadOnlyCollection` from a derived class' method while
the return type in its signature is `ICollection`.

In this case, either the interface is not descriptive enough or the implementation of it violates LSP.