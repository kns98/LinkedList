// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Test myTest = new Test();


Console.ReadLine();

class Node
{
    public string Name { get; set; }
    public Node Next { get; set; }
}

interface IList
{

    void Print();
}

abstract class List : IList
{
    protected Node start = null;

    public void Print()
    {
        if (start == null) return;

        Node n = start;

        while (n.Next != null)
        {
            Console.WriteLine(n.Name);
            n = n.Next;
        }

        Console.WriteLine(n.Name);
    }
}



class LinkedList : List
{
    public LinkedList()
    {

    }

    //
    // Optimization to keep add Operation O(1)
    // O(1) = time taken = one item
    //
    // Without this it would be O(n)
    // O(n) means run through the entire list. i.e. all the items.
    //
    private Node lastNode = null;

    public void addEnd(Node n)
    {
        Node copy = new Node();
        copy.Name = n.Name;
        copy.Next = null;

        if (start == null && lastNode == null)
        {
            start = copy;
            lastNode = copy;
        }
        else
        {
            lastNode.Next = copy;
            lastNode = copy;
        }
    }


   



}

class Test
{
    public string name1 = "John";
    public string name2 = "Doe";
    public string name3 = "Mary";
    public string name4 = "Susan";
    public string name5 = "Johnny";

    LinkedList l1 = new LinkedList();
    LinkedList l2 = new LinkedList();

    public Node node1 = new Node();
    public Node node2 = new Node();
    public Node node3 = new Node();
    public Node node4 = new Node();
    public Node node5 = new Node();

    public Test()
    {
        node1.Name = name1;
        node2.Name = name2;
        node3.Name = name3;
        node4.Name = name4;
        node5.Name = name5;

        l1.addEnd(node1);
        l1.addEnd(node2);
        l1.addEnd(node3);
        l1.Print();

        l2.addEnd(node2);
        l2.addEnd(node4);
        l2.addEnd(node5);
        l2.Print();

    }

}