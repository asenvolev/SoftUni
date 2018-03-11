using System.Text;

public class Seat : ICar
{
    public string Color { get; private set; }

    public string Model { get; private set; }
    public Seat(string model,string color)
    {
        this.Color = color;
        this.Model = model;
    }
    public string Start()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}");
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