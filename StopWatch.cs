public class StopWatch : ICounter
{
    DateTime startTime;
    public StopWatch()
    {
        startTime = DateTime.Now;
    }
    public int Current()=> (int)(DateTime.Now - startTime).TotalSeconds;
}