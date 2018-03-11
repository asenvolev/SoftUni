using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T something;
        public Box(T something)
        {
            this.something = something;
        }
        public override string ToString()
        {
            return $"{this.something.GetType().FullName}: {this.something}";
        }
    }
}
