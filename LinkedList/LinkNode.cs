using System;

public class LinkNode<T>
{
    public T Value { get; set; }
    public LinkNode<T> Next { get; set; }

    public LinkNode(T value)
    {
        Value = value;
        Next = null;
    }
}

public static class LinkNodeUtility
{
    public static void Append<T>(LinkNode<T> head, T value)
    {
        var newNode = new LinkNode<T>(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = newNode;
        }
    }

    public static void Print<T>(LinkNode<T> head)
    {
        var node = head;
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Next;
        }
    }

    public static LinkNode<T> Reverse<T>(LinkNode<T> head)
    {
        var current = head;
        LinkNode<T> prev = null;
        while (current != null)
        {
            var temp = current.Next;
            current.Next = prev;

            prev = current;
            current = temp;
        }

        return prev;
    }

    public static LinkNode<T> RecursiveReserve<T>(LinkNode<T> head){
        if (head == null || head.Next == null){
            return head;
        }

        var temp = RecursiveReserve(head.Next);
        head.Next.Next = head;
        head.Next = null;

        return temp;
    }

    public static LinkNode<T> GetMiddleValue<T>(LinkNode<T> head){
        var slow = head;
        var fast = head;

        while(fast != null && fast.Next != null){
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }
}