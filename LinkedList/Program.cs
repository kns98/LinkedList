// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Test myTest = new Test();


Console.ReadLine();

class Node
{
    public string Name { get; set; }
    public Node Next { get; set; }
}

class List
{
    public List()
    {

    }

    public Node start = null;

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
        if (start == null && lastNode == null)
        {
            start = n;
            lastNode = n;
        }
        else
        {
            lastNode.Next = n;
            lastNode = n;
        }
    }

    public void Print()
    {
        if (start == null) return;

        Node n = start;

        while(n.Next!=null)
        {
            Console.WriteLine(n.Name);
            n = n.Next;
        }

        Console.WriteLine(n.Name);

    }

   



}

class Test
{
    public string name1 = "John";
    public string name2 = "Doe";
    public string name3 = "Mary";
    public string name4 = "Susan";
    public string name5 = "Johnny";

    List l = new List();

    public Node node1 = new Node();
    public Node node2 = new Node();
    public Node node3 = new Node();


    public Test()
    {
        node1.Name = name2;
        node2.Name = name4;
        node3.Name = name3;

        l.addEnd(node1);
        l.addEnd(node2);
        l.addEnd(node3);

        l.Print();

    }

}