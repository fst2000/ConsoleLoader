public class Loader
{
    StopWatch stopWatch;
    int duration;
    public Loader(StopWatch stopWatch, int duration)
    {
        this.stopWatch = stopWatch;
        this.duration = duration;
    }
    public int LoadPercent() => Math.Min((int)(stopWatch.PassedTime() * (100d / duration)),100);
}