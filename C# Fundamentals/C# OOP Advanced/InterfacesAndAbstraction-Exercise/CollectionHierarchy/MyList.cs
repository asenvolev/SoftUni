using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class MyList<T> : Collection<T>, IMyList<T>
    {
        public int Add(T element)
        {
            this.List.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            var removed = this.List[0];
            this.List.RemoveAt(0);
            return removed;
        }

        public int Used()
        {
            return this.List.Count;
        }
    }
}
