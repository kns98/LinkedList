// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Test myTest = new Test();

//
// current to next is called iteration
//

Node currentNode = myTest.node1;
Console.WriteLine("Starting Node: " + currentNode.Name);
currentNode = currentNode.Next;
Console.WriteLine("Next Node: " + currentNode.Name);
currentNode = currentNode.Next;
Console.WriteLine("Next Node: " + currentNode.Name);

Console.ReadLine();

class Node
{
    public string Name { get; set; }
    public Node Next { get; set; }
}

class Test
{
    public string name1 = "John";
    public string name2 = "Doe";
    public string name3 = "Mary";
    public string name4 = "Susan";
    public string name5 = "Johnny";

    public Node node1 = new Node();
    public Node node2 = new Node();
    public Node node3 = new Node();

    public Test()
    {

        node1.Name = name2;
        node1.Next = node2;

        node2.Name = name4;
        node2.Next = node3;

        //last node has null - doesn't point anywhere
        node3.Name = name3;
        node3.Next = null;

    }

}