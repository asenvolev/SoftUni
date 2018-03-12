using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IDatabase
    {
        void Add(int element);
        void Remove();
        int[] Fletch();
    }
}
