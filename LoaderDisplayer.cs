public class LoaderDisplayer
{
    Loader loader;
    int length;
    public LoaderDisplayer(Loader loader, int length)
    {
        this.loader = loader;
        this.length = length;
    }
    public void Display()
    {
        Console.Write('[');
        for(int i = 0; i < loader.LoadPercent() / (100/length); i++)
        {
            Console.Write('=');
        }
        Console.Write(']');
        Console.WriteLine();
    }
}