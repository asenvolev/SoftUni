using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex;
        public Stack()
        {
            this.elements = new List<T>();
            currentIndex = 0;
        }
        public Stack(List<T> collection)
        {
            this.elements = collection;
            currentIndex = 0;
        }
        public void Pop()
        {
            if (elements.Any())
            {
                this.elements.RemoveAt(elements.Count - 1);
            }
            else
            {
                throw new ArgumentException("No elements");
            }
        }
        public void Push(params T[] collection)
        {
            this.elements.AddRange(collection);
        }
        public string Print()
        {
            if (currentIndex<this.elements.Count)
            {
                return $"{this.elements[currentIndex]}";
            }
            else
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count-1; i >=0 ; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this.GetEnumerator();
        }
    }
}
