using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private readonly List<T> elements;
        public Lake(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Count; i+=2)
            {
                yield return this.elements[i];
            }
            int lastOdd = this.elements.Count - 1;
            if (lastOdd % 2==0)
            {
                lastOdd--;
            }
            for (int i = lastOdd; i > 0; i-=2)
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
