using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedDatabase
{
    public class Person
    {
        public Person(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }
        public long Id { get; set; }
        public string Username { get; set; }
    }
}
