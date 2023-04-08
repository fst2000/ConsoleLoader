public class ConsolePrinter
{
    public void Print(string text)
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(0,Console.CursorTop);
        Console.Write(text);
    }
}