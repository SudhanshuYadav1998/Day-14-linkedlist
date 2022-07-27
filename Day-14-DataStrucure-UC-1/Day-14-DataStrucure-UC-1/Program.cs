using System.Collections.Generic;

public class LinkedListProblem
{
    internal Node head;
    internal void Add(int data)
    {
        Node node = new Node(data);
        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        Console.WriteLine("{0} inserted into linked list", node.data);

        }
    }


internal class Node
{
    public int data;
    public Node next;

    public Node(int data)
    { this.data = data; }
    
}

class Program
{
    static void Main(string[] args)
    {
        LinkedListProblem list = new LinkedListProblem();
        list.Add(56);
        list.Add(30);
        list.Add(70);
    }
}