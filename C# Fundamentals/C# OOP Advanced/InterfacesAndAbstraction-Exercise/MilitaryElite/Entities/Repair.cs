namespace MilitaryElite
{
    public class Repair
    {
        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.HoursWorked = hours;
        }
        public string PartName { get; private set; }
        public int HoursWorked { get; private set; }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}