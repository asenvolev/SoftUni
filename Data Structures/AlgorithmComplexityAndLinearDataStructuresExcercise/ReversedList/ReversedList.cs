using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReversedList<T> : IEnumerable<T>
{
    private const int DefaultCapacity = 2;
    private T[] arr;

    public ReversedList(int capacity = DefaultCapacity)
    {
        this.arr = new T[capacity];
        this.Capacity = capacity;
        this.Count = 0;
    }

    public int Count { get; private set; }

    public int Capacity { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.arr[this.Count - 1 - index];
        }

        set
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.arr[this.Count-1-index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count + 1 > this.Capacity)
        {
            this.Capacity *= 2;
            Array.Resize(ref this.arr, this.Capacity);
        }
        this.arr[this.Count] = item;
        this.Count++;
    }

    public T RemoveAt(int index)
    {
        T element = this[index];
        this.ShifLeft(this.Count -1 -index);
        this.Count--;

        return element;
    }

    private void ShifLeft(int index)
    {
        for (int i = index; i < this.Count-1; i++)
        {
            this.arr[i] = this.arr[i + 1];
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

