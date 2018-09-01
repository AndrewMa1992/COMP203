using System;
public class IntList
{
    private Node head;
    private Node current;//This will have latest node

    private Node left;
    public int count = 0;

    public IntList()
    {
        this.head = new Node();
        this.current = head;
    }

    public void Add(int data)
    {
        Node newNode = new Node();
        newNode.Value = data;
        this.current.Next = newNode;
        this.current = newNode;
        count++;
    }

    public Node Find(int n)
    {
        current = head.Next;
        for (int i = 1; i < n; i++)
        {
            current = current.Next;
        }
        return current;
    }

    public Node Remove(int n)
    {
        Node removedNode = null;
        if (this.head != null)
        {
            this.left = head;
            this.current = head.Next;
            for (int i = 2; i <= n && this.current.Next != null; i++)
            {
                this.left = this.current;
                this.current = this.left.Next;
            }
            this.left.Next = this.current.Next;

            removedNode = this.current;
            this.current = null;
        }
        return removedNode;
    }

    public void Insert(Node preNode, int data)
    {
        if (preNode == null)
        {
            Console.WriteLine("The given previous node cannot be null");
            return;
        }

        Node newNode = new Node(data);
        newNode.Next = preNode.Next;
        preNode.Next = newNode;
    }
    public void Dump()
    {
        Console.Write("Head ->");
        Node curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
            Console.Write(curr.Value);
            Console.Write("->");
        }
        Console.WriteLine("NULL");
    }

    public void Isort()
    {
        for (int i = 1; i <= count; ++i)
        {
            int key = this.Remove(i).Value;
            int j = i - 1;
            while (j >= 0 && this.Find(j).Value > key)
            {
                j = j - 1;

            }
            this.Insert(this.Find(j), key);
        }
    }
    public void Qsort(int left, int right)
    {
        int i, j, t, temp;
        if (left > right) return;
        temp = this.Find(left).Value;
        i = left;
        j = right;
        while (i != j)
        {
            while (this.Find(j).Value >= temp && i < j) j--;
            while (this.Find(i).Value <= temp && i < j) i++;
            if (i < j)
            {
                t = this.Find(i).Value;
                this.Find(i).Value = this.Find(j).Value;
                this.Find(j).Value = t;
            }
        }
        this.Find(left).Value = this.Find(i).Value;
        this.Find(i).Value = temp;
        Qsort(left, i - 1);
        Qsort(i + 1, right);

    }
}
