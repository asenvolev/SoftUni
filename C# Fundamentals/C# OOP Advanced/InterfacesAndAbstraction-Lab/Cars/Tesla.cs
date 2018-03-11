using System.Text;

public class Tesla : IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Color = color;
        this.Model = model;
        this.Battery = battery;
    }
    public string Color { get; private set; }
    public string Model { get; private set; }
    public int Battery { get; private set; }


    public string Start()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries");
        sb.AppendLine("Engine start");
        return sb.ToString().Trim();
    }

    public string Stop()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Breaaak");
        return sb.ToString().Trim();
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(Start());
        sb.AppendLine(Stop());
        return sb.ToString().Trim();
    }
}