using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic
{
    public class Clinic
    {
        private int rooms;
        private RoomsRegister roomReg;
        private int ocupiedRooms;
        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = rooms;
            this.roomReg = new RoomsRegister(rooms);
            this.ocupiedRooms = 0;
        }
        public string Name { get; private set; }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }

            private set
            {
                if (value%2==0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
                this.rooms = value;
            }
        }
        public bool AddPet(Pet currPet)
        {
            foreach (var room in this.roomReg)
            {
                if (this.roomReg[room] == null)
                {
                    this.roomReg[room] = currPet;
                    this.ocupiedRooms++;
                    return true;
                }
            }
            return false;
        }
        public bool ReleasePet()
        {
            int centralRoomIndex = this.Rooms / 2;
            for (int i = 0; i < this.Rooms; i++)
            {
                int currentIndex = (centralRoomIndex + i) % this.Rooms;
                if (this.roomReg[currentIndex] != null)
                {
                    this.roomReg[currentIndex] = null;
                    this.ocupiedRooms--;
                    return true;
                }
            }
            return false;
        }
        public bool HasEmptyRooms()
        {
            return this.Rooms > this.ocupiedRooms;
        }
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Rooms; i++)
            {
                sb.AppendLine(this.Print(i));
            }

            return sb.ToString().TrimEnd();
        }

        public string Print(int roomIndex)
        {
            return this.roomReg[roomIndex]?.ToString() ?? "Room empty";
        }
    }
}
