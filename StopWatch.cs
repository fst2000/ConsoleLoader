public class StopWatch
{
    DateTime startTime;
    public StopWatch()
    {
        startTime = DateTime.Now;
    }
    public double PassedTime()=> (DateTime.Now - startTime).TotalSeconds;
}