using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Database : IDatabase
    {
        private readonly IList<int> stack;
        public Database(params int[] elements)
        {
            this.stack = new List<int>(elements);
        }
        public void Add(int element)
        {
            if (this.stack.Count >= 16)
            {
                throw new InvalidOperationException("It is full");
            }
            else
            {
                stack.Add(element);
            }
        }

        public void Remove()
        {
            if (this.stack.Count == 0)
            {
                throw new InvalidOperationException("It is empty");
            }
            else
            {
                stack.Remove(stack.Last());
            }
        }

        public int[] Fletch()
        {
            return this.stack.ToArray();
        }
    }
}
