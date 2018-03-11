using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        public T Value { get; private set; }
        public Box(T something)
        {
            this.Value = something;
        }
        
        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
