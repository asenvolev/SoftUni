using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    public class RoomsRegister : IEnumerable<int>
    {
        private readonly List<Pet> rooms;
        private readonly int centerRoomIndex;
        public RoomsRegister(int rooms)
        {
            this.rooms = new List<Pet>(new Pet[rooms]);
            this.centerRoomIndex = rooms / 2;
        }
        public Pet this[int index]
        {
            get { return this.rooms[index]; }
            set { this.rooms[index] = value; }
        }
        public IEnumerator<int> GetEnumerator()
        {
            int step = 1;

            yield return this.centerRoomIndex;

            while (step <= this.centerRoomIndex)
            {
                yield return this.centerRoomIndex - step;

                yield return this.centerRoomIndex + step++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
