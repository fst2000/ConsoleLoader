static class Program
{
    static void Main()
    {
        int duration = 100;
        int sleepTime = 100;
        Event counterEvent = new Event();
        ICounter arrayCounter = new Counter(counterEvent);
        Loader loader = new Loader(arrayCounter, duration);
        ConsolePrinter printer = new ConsolePrinter();
        LoaderDisplayer loaderDisplayer = new LoaderDisplayer(loader, printer, 20);
        int[] array = new int[duration];
        foreach(var a in array)
        {
            counterEvent.Call();
            loaderDisplayer.Display();
            Thread.Sleep(sleepTime);
        }
    }
}
