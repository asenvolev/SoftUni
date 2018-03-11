public class ArrayCreator
{
    public static T[] Create<T>(int count, T element)
    {
        var array = new T[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = element;
        }
        return array;
    }
}