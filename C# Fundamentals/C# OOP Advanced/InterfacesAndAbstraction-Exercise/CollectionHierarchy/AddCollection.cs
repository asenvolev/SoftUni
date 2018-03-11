using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy
{
    public class AddCollection<T> : Collection<T>, IAddCollection<T>
    {
        public int Add(T element)
        {
            this.List.Add(element);
            return this.List.Count - 1;
        }
    }
}
