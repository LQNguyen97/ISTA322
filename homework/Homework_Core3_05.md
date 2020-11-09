# Linh Nguyen
## ASP.NET Core 3 Homework 05

1.What is the purpose of the null conditional operator? Does it apply to value types or reference types?
Why or why not?

	Don’t get a NullReferenceException when navigating through the object properties, Reference, 

2.What is the null coalescing operator? What does it do?

	(??) don’t include null values in the results displayed in the browser.

3.How is the null conditional operator different from a nullable type? What is the purpose of nullable
types?

	Null conditional operator Treats null as a valid value for all types, which means that I can assign null to a string variable
	Nullable type regular reference types cannot be assigned null values, such as assigning null to a string

4.When you create an automatic property and initialize the property with a value, can the value be
changed later? Can another value be assigned to the property? Can the value be changed in the
constructor?

	Yes, yes. No The property value cannot be changed once set by the constructor

5.What is an object initializer and what is it for? What is an collection initializer and what is it for?

	Initializer: Allows to create an object and specify its property values in a single step
	Collection:  allows the contents of the array to be specified as part of the construction, which implicitly provides
	the compiler with the size of the array

6.What does the is keyword do?

	The is operator checks if the result of an expression is compatible with a given type, 
	or tests an expression against a pattern.
	(Used to perform a type test)

7.How are extension methods defined?

	Extension methods are defined in static classes within the same namespace as the class the extension methods applies to. 

8.What is implicit typing or type inference? How do you implement it?

	The var keyword allows you to define a local variable without explicitly specifying the variable type
	EX. var names = new [] { "Kayak", "Lifejacket", "Soccer ball" };

9.What is a default implementation of an interface? What is the purpose of a default implementation
of an interface?
 
	To define default implementations for properties and methods defined by interfaces.
	Makes it possible to update interfaces without breaking the existing implementations of them. 

10.What are asynchronous methods? Why should we use them? How are they used?

	Perform work in the background and notify you when they are complete, allowing your code to take care
	of other business while the background work is performed.
	Allow applications to take advantage of multiple processors and processor cores to perform work in parallel.
	Improve the overall performance of an application by allowing the server more flexibility in the way that requests
	are scheduled and executed.

11.When you use the await keyword, do you have to use the async keyword? Why or why not?

	Yes. The async keyword enables the await keyword. So any method using await must be marked async.

12.(not in book) What is the yield keyword used for? How do you use it?

	Indicate that the method, operator, or get accessor in which it appears is an iterator
	Using yield to define an iterator removes the need for an explicit extra class
	Yield return <expression>;
	yield break;

13.What is the effect of using the nameof() expression?

	produces the name of a variable, type, or member as the string constant