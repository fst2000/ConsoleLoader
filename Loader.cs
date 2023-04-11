public class Loader
{
    ICounter counter;
    int duration;
    public Loader(ICounter counter, int duration)
    {
        this.counter = counter;
        this.duration = duration;
    }
    public int LoadPercent() => Math.Min((int)(counter.Current() * (100d / duration)),100);
}