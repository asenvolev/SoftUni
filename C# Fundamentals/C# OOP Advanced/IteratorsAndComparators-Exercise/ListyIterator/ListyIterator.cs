using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex;
        public ListyIterator()
        {
            this.elements = new List<T>();
            currentIndex = 0;
        }
        public ListyIterator(List<T> collection)
        {
            this.elements = collection;
            currentIndex = 0;
        }
        public bool Move()
        {
            if (this.elements.Count > ++currentIndex)
            {
                return true;
            }
            else
            {
                --currentIndex;
                return false;
            }
        }
        public bool HasNext()
        {
            return currentIndex < this.elements.Count - 1;
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
            for (int i = 0; i < this.elements.Count; i++)
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
