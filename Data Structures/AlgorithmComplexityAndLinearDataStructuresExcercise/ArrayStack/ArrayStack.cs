using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ArrayStack<T>
{
    private const int InitialCapacity = 16;

    private T[] elements;

    public int Count { get; private set; }

    public ArrayStack(int capacity = InitialCapacity)
    {
        this.elements = new T[capacity];
        this.Count = 0;
    }

    public void Push(T element)
    {
        if (this.Count>=this.elements.Length)
        {
            this.Grow();
        }
        this.elements[this.Count++] = element;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty!");
        }
        
        return this.elements[--this.Count];
    }

    public T[] ToArray()
    {
        T[] result = new T[this.Count];
        Array.Copy(this.elements,result,this.Count);
        Array.Reverse(result);
        return result;
    }

    private void Grow()
    {
        Array.Resize(ref this.elements, this.elements.Length*2);
    }

}

