// See https://aka.ms/new-console-template for more information
using System.Security;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

Test myTest = new Test();



Console.ReadLine();

abstract class Node
{
    public string Name { get; set; }

}

class SingleNode : Node
{
    public SingleNode Next { get; set; }
}

class DoubleNode : Node
{
    //black arrow
    public DoubleNode Next { get; set; }

    //pink arrow
    public DoubleNode Prev { get; set; }
}

interface IList
{

    void Print();
}

enum ListType
{
    Single,
    Double
}


abstract class List : IList
{
    protected Node start = null;
    protected Node lastNode = null;

    protected  ListType Type { get; set; }

    public Node GetStart()
    {
        return start;
    }

    public List(ListType type)
    {
        Type = type;
    }

    public  void Print()
    {
        if (Type == ListType.Single)
        {
            SingleNode _start = start as SingleNode;

            if (start == null) return;

            SingleNode n = _start;

            while (n.Next != null)
            {
                Console.WriteLine(n.Name);
                n = n.Next;
            }

            Console.WriteLine(n.Name);
        }
        else if (Type == ListType.Double)
        {
            DoubleNode _start = start as DoubleNode;

            if (start == null) return;

            DoubleNode n = _start;

            while (n.Next != null)
            {
                Console.WriteLine(n.Name);
                n = n.Next;
            }

            Console.WriteLine(n.Name);
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}

/*
class DoubleLinkedList : List
{
    public DoubleLinkedList() : base(ListType.Double)
    {

    }
}
*/

class SingleLinkedList : List
{
    public SingleLinkedList() : base(ListType.Single)
    {

    }

    public void addEnd(Node n)
    {
        SingleNode _snode = null;
        DoubleNode _dnode = null;

        if (Type == ListType.Single)
        {
            _snode = n as SingleNode;
            SingleNode _lastNode = lastNode as SingleNode;

            SingleNode copy = new SingleNode();
            copy.Name = _snode.Name;
            copy.Next = null;

            if (start == null && _lastNode == null)
            {
                start = copy;
                lastNode = copy;
            }
            else
            {
                _lastNode.Next = copy;
                lastNode = copy;
            }
        }
        else
        {
            throw new NotImplementedException();
        }


    }

    
}


class DoubleLinkedList : List
{
    public DoubleLinkedList() : base(ListType.Double)
    {

    }

    public void addEnd(Node n)
    {
        DoubleNode _snode = null;
        DoubleNode _dnode = null;

        if (Type == ListType.Double)
        {
            _snode = n as DoubleNode;
            DoubleNode _lastNode = lastNode as DoubleNode;
            DoubleNode copy = new DoubleNode();

            copy.Name = _snode.Name;
            copy.Next = null;
            copy.Prev = null;

            if (start == null && _lastNode == null)
            {
                start = copy;
                lastNode = copy;
            }
            else
            {
                _lastNode.Next = copy;
                _lastNode.Next.Prev = _lastNode;
                lastNode = copy;
            }
        }
        else
        {
            throw new NotImplementedException();
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

    SingleLinkedList sl1 = new SingleLinkedList();
    
    public SingleNode snode1 = new SingleNode();
    public SingleNode snode2 = new SingleNode();
    public SingleNode snode3 = new SingleNode();
    public SingleNode snode4 = new SingleNode();
    public SingleNode snode5 = new SingleNode();

    DoubleLinkedList dl1 = new DoubleLinkedList();

    public DoubleNode dnode1 = new DoubleNode();
    public DoubleNode dnode2 = new DoubleNode();
    public DoubleNode dnode3 = new DoubleNode();
    public DoubleNode dnode4 = new DoubleNode();
    public DoubleNode dnode5 = new DoubleNode();



    public Test()
    {
        TestSingle();
        TestDouble();
    }
    
    private void TestDouble()
    {
        dnode1.Name = name1;
        dnode2.Name = name2;
        dnode3.Name = name3;
        dnode4.Name = name4;
        dnode5.Name = name5;

        dl1.addEnd(dnode1);
        dl1.addEnd(dnode2);
        dl1.addEnd(dnode3);
        dl1.addEnd(dnode2);
        dl1.addEnd(dnode4);
        dl1.addEnd(dnode5);

        DoubleNode cur = dl1.GetStart() as DoubleNode;

        Console.WriteLine("Testing Next and Prev");
        Console.WriteLine( cur.Next.Next.Next.Next.Next.Prev.Name );


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Printing Double Linked List");
        dl1.Print();

    }

    private void TestSingle()
    {
        snode1.Name = name1;
        snode2.Name = name2;
        snode3.Name = name3;
        snode4.Name = name4;
        snode5.Name = name5;

        sl1.addEnd(snode1);
        sl1.addEnd(snode2);
        sl1.addEnd(snode3);
        sl1.addEnd(snode2);
        sl1.addEnd(snode4);
        sl1.addEnd(snode5);




        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Printing Single Linked List");
        sl1.Print();

    }

}