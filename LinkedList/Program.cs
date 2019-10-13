using System;

namespace LinkedList
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Print Middle Length with one Pass");

      LinkedList ll = new LinkedList();

      ll.AddNode(new Node("1"));
      ll.AddNode(new Node("2"));
      ll.AddNode(new Node("3"));
      ll.AddNode(new Node("4"));
      ll.AddNode(new Node("5"));
      ll.AddNode(new Node("6"));
      ll.AddNode(new Node("7"));
      ll.AddNode(new Node("8"));
      ll.AddNode(new Node("9"));

      Node head = ll.Head;

      Node current = head;
      Node middle = head;
      int length = 0;

      while (current.Next != null)
      {
        length++;

        if (length % 2 == 0)
        {
          middle = middle.Next;
        }

        current = current.Next;
      }

      if (length % 2 == 1)
      {
        middle = middle.Next;
      }

      Console.WriteLine($"length:{length}");
      Console.WriteLine($"Current Node:{current.Name}");
      Console.WriteLine($"Middle Node:{middle.Name}");
      Console.ReadLine();
    }
  }

  public class LinkedList
  {
    public Node Head { get; private set; }
    public Node Tail { get; private set; }

    public LinkedList()
    {
      this.Head = new Node("Head");
      this.Tail = Head;
    }

    public void AddNode(Node nodeToBeAdded)
    {
      this.Tail.Next = nodeToBeAdded;
      this.Tail = nodeToBeAdded;
    }
  }

  public class Node
  {
    public Node Next { get; set; }
    public string Name { get; set; }

    public Node(string name)
    {
      this.Name = name;
    }
  }
}
