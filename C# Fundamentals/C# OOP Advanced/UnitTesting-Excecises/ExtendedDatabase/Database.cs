using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedDatabase
{
    public class Database : IDatabase
    {
        private readonly IList<Person> stack;
        public Database(params Person[] elements)
        {
            this.stack = new List<Person>(elements);
        }
        public void Add(Person element)
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

        public Person FindByUsername(string username)
        {
            if (this.stack.Any(x => x.Username == username))
            {
                return this.stack.First(x => x.Username == username);
            }
            else
            {
                throw new InvalidOperationException($"There is no person with username {username}");
            }
        }

        public Person FindById(long id)
        {
            if (this.stack.Any(x => x.Id == id))
            {
                return this.stack.First(x => x.Id == id);
            }
            else
            {
                throw new InvalidOperationException($"There is no person with ID {id}");
            }
        }
    }
}
