using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class AddRemoveCollection<T> : Collection<T>, IAddRemoveCollection<T>
    {
        public int Add(T element)
        {
            this.List.Insert(0,element);
            return 0;
        }

        public T Remove()
        {
            var removed = this.List[List.Count - 1];
            this.List.RemoveAt(List.Count-1);
            return removed;
        }
    }
}
