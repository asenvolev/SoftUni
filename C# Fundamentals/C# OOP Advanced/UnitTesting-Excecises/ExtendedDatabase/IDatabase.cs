using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedDatabase
{
    public interface IDatabase
    {
        void Add(Person man);
        void Remove();
        Person FindByUsername(string username);
        Person FindById(long id);
    }
}
