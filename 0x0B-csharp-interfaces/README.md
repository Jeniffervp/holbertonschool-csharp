# 0x0B. C# - Interfaces

This is a project from Holberton School

![N|Solid](https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Csharp_Logo.png/245px-Csharp_Logo.png)

## Tasks

``Mandatory``

| Task | Description |
| ------ | ------ |
| 0. Abstract thinking  | Create an abstract class called Base containing the following: -public property name: -name should be a string. -override ToString() method to return the following: <name> is a <type> (ex. Garden Gate is a Door) |
| 1. User interface | Based on 0-abstract_thinking, create an interface called IInteractive. -method void Interact(). Create an interface called IBreakable. -property durability; durability should be an int. -method void Break(). Create an interface called ICollectable. -property isCollected; isCollected should be a bool. -method void Collect(). You do not need to fully implement the methods for this task. Create a new class called TestObject that inherits from Base and all three interfaces. |
| 2. Escape room | Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive. -define constructor that sets the value of name. if name isn’t provided, the default value should be Door. -implement Interact() so that it prints: You try to open the <name>. It's locked. |
| 3. Interior decorating | Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable. |
| 4. Key collecting | Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable. |
| 5. Iterate and act | Based on 4-keys, create a new class called RoomObjects and a method called IterateAction. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses IInteractive, your IterateAction method should call Interact() on it). -Class: RoomObjects. -Prototype: public static void IterateAction List<Base> roomObjects, Type type) |
| 6. Better iterating and acting | Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach. -Class: Objs<T>. -Objs<T> must inherit from and implement IEnumerable<T> |