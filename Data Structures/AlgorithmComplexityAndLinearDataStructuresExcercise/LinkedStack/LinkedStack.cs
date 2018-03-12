using System;

public class LinkedStack<T>
{
    private Node<T> firstNode;

    private class Node<T>
    {
        public T value;

        public Node<T> NextNode { get; set; }

        public Node(T value, Node<T> nextNode)
        {
            this.value = value;
            this.NextNode = nextNode;
        }
    }

    public LinkedStack()
    {
        this.Count = 0;
        this.firstNode = null;
    }

    public int Count { get; private set; }

    public void Push(T element)
    {
        this.firstNode = new Node<T>(element, this.firstNode);
        this.Count++;
    }
    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        T element = firstNode.value;
        firstNode = firstNode.NextNode;
        this.Count--;
        return element;
    }
    public T[] ToArray()
    {
        var index = 0;
        T[] result = new T[this.Count];
        while (firstNode != null)
        {
            result[index] = firstNode.value;
            firstNode = firstNode.NextNode;
            index++;
        }
        return result;
    }
}

