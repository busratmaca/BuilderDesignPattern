# BuilderDesignPattern

Builder pattern aims to “Separate the construction of a complex object from its representation so that the same construction process can create different representations.” It is used to construct a complex object step by step and the final step will return the object. The process of constructing an object should be generic so that it can be used to create different representations of the same object.

Advantages of Builder Design Pattern

º The parameters to the constructor are reduced and are provided in highly readable method calls.

º Builder design pattern also helps in minimizing the number of parameters in the constructor and thus there is no need to pass in null for optional         parameters to the constructor.

º Object is always instantiated in a complete state

º Immutable objects can be built without much complex logic in the object building process.


Disadvantages of Builder Design Pattern

º The number of lines of code increases at least to double in builder pattern, but the effort pays off in terms of design flexibility and much more readable code.

º Requires creating a separate ConcreteBuilder for each different type of Product.
