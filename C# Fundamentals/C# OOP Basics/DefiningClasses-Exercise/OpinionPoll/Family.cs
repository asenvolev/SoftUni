using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class Family
    {
        private List<Person> people;
        public Family()
        {
            this.people = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }
        public List<Person> GetOldestMembers()
        {
            return this.people.OrderBy(x=>x.Name).Where(x=>x.Age>30).ToList();
        }
    }
}
