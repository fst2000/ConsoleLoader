using System.Linq;
public class ArrayIterator<T>
{
    T[] array;
    public ArrayIterator(T[] array)
    {
        this.array = array;
    }
    public void Iterate(IProgressConsumer progressConsumer)
    {
        foreach(var i in Enumerable.Range(0, array.Length))
        {
            progressConsumer.Progress(i + 1,array.Length);
            Thread.Sleep(10);
        }
    }
}