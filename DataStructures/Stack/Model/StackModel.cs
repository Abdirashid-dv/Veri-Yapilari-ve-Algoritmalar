@startuml Stack
title Stack

namespace DataStructures.Stack.Contracts
{

    interface IStack<T>
    {
    + Count: int
    + Push(item: T) : void
    + Pop() : T?
    + Peek() : T?
    }
}
namespace DataStructures.Stack
{
    class ArrayStack<T>
    {
        - _innerArray: List<T>
        - LastIndex: int
        + Count: int
        + ArrayStack()
        + ArrayStack(collection: IEnumerable<T>)
        + Peek() : T?
        + Pop() : T?
        + Push(item: T) : void
    }

    class LinkedListStack<T>
    {
        - _innerList: SinglyLinkedList<T>
        + LinkedListStack()
        + LinkedListStack(collection: IEnumerable<T>)
        + Count: int
        + Peek() : T?
        + Pop() : T?
        + Push(item: T) : void
    }

    class Stack<T>
    {
    - _stack: IStack<T>?
    + Count: int
    + Peek() : T?
    + Pop() : T?
    + Push(item: T) : void
    }
}

DataStructures.Stack.ArrayStack.up.|> DataStructures.Stack.Contracts.IStack : "<<implements>>"
DataStructures.Stack.LinkedListStack.down.|> DataStructures.Stack.Contracts.IStack : "<<implements>>"
DataStructures.Stack.Stack.left.|> DataStructures.Stack.Contracts.IStack : "<<implements>>"

@enduml