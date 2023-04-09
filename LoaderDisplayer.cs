public class LoaderDisplayer
{
    Loader loader;
    ConsolePrinter printer;
    int length;
    public LoaderDisplayer(Loader loader, ConsolePrinter printer, int length)
    {
        this.loader = loader;
        this.printer = printer;
        this.length = length;
    }
    public void Display()
    {
        string loadPercent = Convert.ToString(loader.LoadPercent()) + "%";
        int loadedBarLength = Math.Max(loader.LoadPercent() / (100/length) - loadPercent.Length, 0);
        string loadedBar = new String('=', loadedBarLength);
        string unloadedBar = new String('-',length - loadedBarLength - loadPercent.Length);
        string allBar = "[" + loadedBar + loadPercent + unloadedBar +"]";
        printer.Print(allBar);
    }
}