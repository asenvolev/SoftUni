using BashSoft.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.DataStructures
{
    public class SimpleSortedList<T> : ISimpleOrderedBag<T> where T : IComparable<T>
    {
        private const int DefaultSize = 16;
        private T[] innerCollection;
        private int size;
        private IComparer<T> comparison;

        public SimpleSortedList(IComparer<T> comparison, int capacity)
        {
            this.comparison = comparison;
            this.InitializeInnerCollection(capacity);
        }

        public SimpleSortedList(int capacity)
            : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), capacity)
        {
        }

        public SimpleSortedList(IComparer<T> comparison)
            : this(comparison, DefaultSize)
        {
        }

        public SimpleSortedList()
            : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), DefaultSize)
        {
        }

        private void InitializeInnerCollection(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative!");
            }
            this.innerCollection = new T[capacity];
        }

        public int Size
        {
            get { return this.size; }
        }

        public int Capacity
        {
            get
            {
                return this.innerCollection.Length;
            }
        }

        public void Add(T element)
        {
            if (element == null)
            {
                throw new ArgumentException();
            }
            if (this.innerCollection.Length == this.Size)
            {
                this.Resize();
            }
            this.innerCollection[size] = element;
            this.size++;
            Array.Sort(this.innerCollection, 0, size, comparison);
        }

        private void Resize()
        {
            T[] newCollection = new T[this.Size * 2];
            Array.Copy(innerCollection, newCollection, Size);
            innerCollection = newCollection;
        }

        public void AddAll(ICollection<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentException();
            }
            if (this.size + collection.Count >= this.innerCollection.Length)
            {
                this.MultiResize(collection);
            }
            foreach (var elemet in collection)
            {
                this.innerCollection[this.size] = elemet;
                this.size++;
            }
            Array.Sort(this.innerCollection, 0, this.size, this.comparison);
        }

        private void MultiResize(ICollection<T> collection)
        {
            int newSize = this.innerCollection.Length * 2;
            while (this.Size + collection.Count >= newSize)
            {
                newSize *= 2;
            }
            T[] newCollection = new T[newSize];
            Array.Copy(this.innerCollection, newCollection, this.size);
            this.innerCollection = newCollection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Size; i++)
            {
                yield return this.innerCollection[i];
            }
        }

        public string JoinWith(string joiner)
        {
            if (joiner == null)
            {
                throw new ArgumentException();
            }
            var sb = new StringBuilder();
            foreach (var item in this)
            {
                sb.Append(item).Append(joiner);
            }
            sb.Remove(sb.Length - joiner.Length, joiner.Length);
            return sb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Remove(T element)
        {
            if (element == null)
            {
                throw new ArgumentException();
            }
            bool hasBeenRemoved = false;
            int indexOfRemovedElement = 0;
            for (int i = 0; i < Size; i++)
            {
                if (this.innerCollection[i].Equals(element))
                {
                    indexOfRemovedElement = i;
                    this.innerCollection[i] = default(T);
                    hasBeenRemoved = true;
                    break;
                }
            }
            if (hasBeenRemoved)
            {
                for (int i = indexOfRemovedElement; i < this.Size-1; i++)
                {
                    this.innerCollection[i] = this.innerCollection[i + 1];
                }
                this.innerCollection[this.Size - 1] = default(T);
                this.size--;
            }
            return hasBeenRemoved;
        }
    }
}