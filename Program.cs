static class Program
{
    static void Main()
    {
        int duration = 5;
        StopWatch stopWatch = new StopWatch();
        Loader loader = new Loader(stopWatch, duration);
        ConsolePrinter printer = new ConsolePrinter();
        LoaderDisplayer loaderDisplayer = new LoaderDisplayer(loader, printer, 20);
        while(true)
        {
            loaderDisplayer.Display();
            Thread.Sleep(10);
        }
    }
}
