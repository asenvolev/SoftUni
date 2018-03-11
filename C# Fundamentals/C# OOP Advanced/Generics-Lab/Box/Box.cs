using System.Collections.Generic;
using System.Linq;
public class Box<T>
{
    private IList<T> box;
    public Box()
    {
        this.box = new List<T>();
    }
    public void Add(T element)
    {
        this.box.Add(element);
    }
    public T Remove()
    {
        var last = this.box.LastOrDefault();
        this.box.RemoveAt(box.Count-1);
        return last;
    }
    public int Count => this.box.Count;
}