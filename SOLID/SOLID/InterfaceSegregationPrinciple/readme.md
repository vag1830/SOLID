### *I* - Interface Segregation Principle (*ISP*)

##### History

The Interface Segregation Principle was defined by Robert C. Martin (Uncle Bob) while consulting 
for Xerox to help them build the software for their new printer systems. 

> “Clients should not be forced to depend upon interfaces that they do not use.”

##### Definition

> No client should be forced to depend on methods it does not use.

Similar to the Single Responsibility Principle, the goal of the ISP is to reduce the side effects and 
frequency of required changes by splitting the software into multiple, independent parts.

This is achievable if we define interfaces so that they fit a specific client or task.

The SOLID principles are closely related to one another. 
The ISP is particularly closely associated with the 
Liskov Substitution Principle (LSP) and the Single Responsibility Principle (SRP)

##### Code Smells for ISP Violations

* Big Interfaces.
  * According to ISP we should need most or all methods of an interface. In a bulky interface, 
we most commonly only need a few of them in each case. 

* Another indication of an ISP violation is when we have to pass null or equivalent value into a method.
  * One can angue that the below interface is poorly designed, or it violates the the ISP. 
  Most likely the different methods below are to be used by different clients.
```C#
	public interface IBurgerOrderService 
	{
		public void OrderBurger(int qty); 
		public void OrderFries(int qty); 
		public void OrderBurgerAndFries(int burgerQty, int friesQty);
	}
```

* Methods Throwing Exceptions
  * Throwing `UnsupportedOperationException`, `NotImplementedException`, or similar exceptions.
This is usually an indication for a violation of the ISP as well as the LSP.

* Testing needs giant setup and the becomes too big.

#### Examples...

https://www.code.lidozrh.ch/projects/FMS/repos/fmsmsavis/browse/FmsDatabase.cs?at=e2ffb5433128061f191d75871ca6b41f36bb5559


