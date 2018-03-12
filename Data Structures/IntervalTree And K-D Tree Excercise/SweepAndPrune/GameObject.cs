public class GameObject
{
    public GameObject(string name, double x1, double y1)
    {
        this.X1 = x1;
        this.Y1 = y1;
        this.Name = name;
    }

    public string Name { get; set; }
    public double X1 { get; set; }
    public double X2 { get { return X1 + 10; } }
    public double Y1 { get; set; }
    public double Y2 { get { return Y1 + 10; } }

    public void Move(double newX, double newY)
    {
        this.X1 = newX;
        this.Y1 = newY;
    }
}

