static class Program
{
    static void Main()
    {
        ConsolePrinter printer = new ConsolePrinter();
        LoaderDisplayer loaderDisplayer = new LoaderDisplayer(printer, 20);
        int[] array = new int[200];
        ArrayIterator<int> iterator = new ArrayIterator<int>(array);
        iterator.Iterate(loaderDisplayer);

    }
}
