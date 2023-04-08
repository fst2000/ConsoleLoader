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
        int loadedBarLength = loader.LoadPercent() / (100/length);
        string loadedBar = new String('=', loadedBarLength);
        string allBar = "[" + new String('-', length + loadPercent.Length) + "]";
        printer.Print(allBar);
        printer.Print("[" + loadedBar + loadPercent);
    }
}