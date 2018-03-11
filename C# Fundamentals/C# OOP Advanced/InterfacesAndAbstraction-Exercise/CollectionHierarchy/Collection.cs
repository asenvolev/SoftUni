using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public abstract class Collection<T>
    {
        private readonly IList<T> collection;
        public Collection()
        {
            this.collection = new List<T>();
        }
        public IList<T> List => this.collection;
    }
}
