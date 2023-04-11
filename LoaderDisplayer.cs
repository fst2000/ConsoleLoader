public class LoaderDisplayer : IProgressConsumer
{

    ConsolePrinter printer;
    int length;
    public LoaderDisplayer(ConsolePrinter printer, int length)
    {
        this.printer = printer;
        this.length = length;
    }
    public void Progress(int progress, int end)
    {
        int percent = (int)(progress / (float)end * 100f);
        string loadPercent = percent.ToString() + "%";
        int loadedBarLength = Math.Max(percent / (100/length) - loadPercent.Length, 0);
        string loadedBar = new String('=', loadedBarLength);
        string unloadedBar = new String('-',length - loadedBarLength - loadPercent.Length);
        string allBar = "[" + loadedBar + loadPercent + unloadedBar +"]";
        printer.Print(allBar);
    }
}