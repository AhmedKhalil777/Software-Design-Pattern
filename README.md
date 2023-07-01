# In the Name of ALLAH
# Software-Design-Pattern
---
- In software engineering, a __design pattern__ is a general repeatable solution to a commonly occurring problem in software design.



- A design pattern isn't a finished design that can be transformed directly into code.


- It is a description or template for how to solve a problem that can be used in many different situations.



## Creational Patterns


> In software engineering, creational design patterns are design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. The basic form of object creation could result in design problems or added complexity to the design.

- Creational design patterns solve this problem by somehow controlling this object creation.
- Creational design patterns are composed of two dominant ideas.
  - One is encapsulating knowledge about which concrete classes the system use.
  - Another is hiding how instances of these concrete classes are created and combined.
- Creational design patterns are further categorized into Object-creational patterns and Class-creational patterns
- where Object-creational patterns deal with Object creation and Class-creational patterns deal with Class-instantiation. 
- In greater details, Object-creational patterns defer part of its object creation to another object, while Class-creational patterns defer its objection creation to subclasses.

- Five well-known design patterns that are parts of creational patterns are listed as follows:

|index|Type |Pattern Name| Usage |
|:---:|:----|:-----------|:-----|
|1 | Creational |The Factory Pattern| which allows a class to defer instantiation to subclasses. |
|2 | Creational |The Singleton Pattern|which ensures that a class only has one instance, and provides a global point of access to it. |
|3 | Creational |The Prototype Pattern| which specifies the kind of object to create using a prototypical instance, and creates new objects by cloning this prototype. |
|4 | Creational |[The Builder Pattern](https://github.com/AhmedKhalil777/Software-Design-Pattern/blob/master/4.%20The%20Builder%20Pattern%20__Creational/README.md)|which separates the construction of a complex object from its representation so that the same construction process can create different representation |
|5 | Creational |The Abstract Factory Pattern| which provides an interface for creating related or dependent objects without specifying the objects' concrete classes. |


## Structural Pattern

|index|Type |Pattern Name| Usage |
|:---:|:----|:-----------|:-----|
|6 | Structural |The Proxy Pattern| |
|7 | Structural |The Decorator Pattern| |
|8 | Structural |The Adapter Pattern| |
|9 | Structural |The Facade Pattern| |
|10 | Structural |The Flyweight Pattern| |
|11 | Structural |The Composite Pattern| |
|12 | Structural |The Bridge Pattern| |



## Behavioral Design Patterns

> In software engineering, behavioral design patterns are design patterns that identify common communication patterns between objects and realize these patterns. 

- By doing so, these patterns increase flexibility in carrying out this communication.

- Behavioral patterns influence how state and behavior flow through a system. 
- By optimizing how state and behavior are transferred and modified, you can simplify, optimize, and increase the maintainabilty of an application.

|index|Type |Pattern Name| Usage |
|:---:|:----|:-----------|:-----|
|13 | Behavioral |The Visitor Pattern| A way to separate an algorithm from an object |
|14 | Behavioral |The Observer Pattern| also known as Publish/Subscribe or Event Listener. Objects register to observe an event that may be raised by another object |
|15 | Behavioral |The Pub-Sub Pattern|also known as observer or Event Listener. Objects register to observe an event that may be raised by another object |
|16 | Behavioral |The Strategy (Policy) Pattern| Algorithms can be selected on the fly |
|17 | Behavioral |The Template method Pattern| Describes the program skeleton of a program |
|18 | Behavioral |The Command Pattern| Command objects encapsulate an action and its parameters |
|19 | Behavioral |The Iterator Pattern|Iterators are used to access the elements of an aggregate object sequentially without exposing its underlying representation |
|20 | Behavioral |The Memento Pattern| Provides the ability to restore an object to its previous state (rollback) |
|21 | Behavioral |The State Pattern| A clean way for an object to partially change its type at runtime |
|23 | Behavioral |The Mediator Pattern|Provides a unified interface to a set of interfaces in a subsystem |
|24 | Behavioral |The Chain of Responsibility)Pattern |  Command objects are handled or passed on to other objects by logic-containing processing objects|
|25 | Behavioral |The interpreter Pattern|Implement a specialized computer language to rapidly solve a specific set of problems |


## Other Patterns

|index|Type |Pattern Name| Usage |
|:---:|:----|:-----------|:-----|
|26 | Creational |The Simple factory Pattern| |
|27 | Creational |The Null object Pattern| |
|28 | Architectural |The MVC Model-View-Controller Pattern| |
|29 | Architectural |The MVVM Model-View View-Model Pattern| |
|30 | Architectural |The MVP Model-View-Presenter Pattern| |
|31 | Data Management & Architectural |The CQRS Command Query Responsibiity Segregation Pattern| |
|32 | Data Management|The Cache-Aside Pattern| |
|33 | Data Management|The Event Sourcing Pattern| |
|34 | Data Management|The Index Table Pattern| |
|35 | Data Management|The Meteralized View Pattern| |
|35 | Data Management|The Sharding Pattern| |
