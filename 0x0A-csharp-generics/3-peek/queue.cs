using System;

/// <summary> Class that doesn't inherit </summary>
/// <typeparam name="T"> parameter </typeparam>
class Queue<T> {

  /// <summary>Function to check the type of Queue</summary>
  /// <returns></returns>
  public Type CheckType () {
    return typeof (T);
  }

  /// <summary>Inner Class Node</summary>
  public class Node {
    public T value;
    public Node next;

    public Node (T value) {
      this.value = value;
    }
  }

  public Node head;
  public Node tail;
  public int count = 0;

  /// <summary> Class to create a new node </summary>
  public void Enqueue (T value) {
    Node newNode = new Node (value);
    if (this.head == null) {
      this.head = newNode;
    }
    if (this.tail != null) {
      this.tail.next = newNode;
    }
    this.tail = newNode;
    this.count += 1;
  }

  /// <summary> Method to return the number of nodes in queue </summary>
  public int Count () {
    return this.count;
  }

  /// <summary> Method to remove the head node </summary>
  /// <returns> The value of the removed node </returns>
  public T Dequeue () {

    Node actual;

    if (this.head == null) {
      Console.WriteLine ("Queue is empty");
      return default (T);
    }
    actual = this.head;
    this.head = actual.next;
    count -= 1;

    return actual.value;
  }

  /// <summary> Choose the first node </summary>
  /// <returns> return teh value of the first node </returns>
  public T Peek () {
    if (this.head == null) {
      Console.WriteLine ("Queue is empty");
      return default (T);
    }

    return head.value;
  }
}