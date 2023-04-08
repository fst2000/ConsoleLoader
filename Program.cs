static class Program
{
    static void Main()
    {
        StopWatch stopWatch = new StopWatch();
        int duration = 5;
        Loader loader = new Loader(stopWatch, duration);
        LoaderDisplayer loaderDisplayer = new LoaderDisplayer(loader, 10);
        while(true)
        {
            loaderDisplayer.Display();
            Thread.Sleep(10);
        }
    }
}
