using System;

public class LinkedQueue<T>
{
    private QueueNode<T> head;

    private QueueNode<T> tail;

    public LinkedQueue()
    {
        this.head = null;
        this.tail = null;
        this.Count = 0;
    }

    public int Count { get; private set; }

    public void Enqueue(T element)
    {
        if (this.Count == 0)
        {
            this.tail = this.head = new QueueNode<T>(element);
        }
        else
        {
            var newTail = new QueueNode<T>(element);
            newTail.PrevNode = this.tail;
            this.tail.NextNode = newTail;
            this.tail = newTail;
        }
        this.Count++;
    }
    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("List empty");
        }

        var firstElement = this.head.Value;
        this.head = this.head.NextNode;
        if (this.head != null)
        {
            this.head.PrevNode = null;
        }
        else
        {
            this.tail = null;
        }

        this.Count--;
        return firstElement;
    }
    public T[] ToArray()
    {
        var arr = new T[this.Count];
        var index = 0;
        var currNode = this.head;
        while (currNode != null)
        {
            arr[index] = currNode.Value;
            currNode = currNode.NextNode;
            index++;
        }

        return arr;
    }

    private class QueueNode<T>
    {
        public T Value { get; private set; }
        public QueueNode<T> NextNode { get; set; }
        public QueueNode<T> PrevNode { get; set; }
        public QueueNode(T value)
        {
            this.Value = value;
        }
    }
}


