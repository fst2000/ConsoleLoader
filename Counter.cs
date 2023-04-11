public class Counter : ICounter
{
    int current;
    public Counter(IEvent onIterationEvent)
    {
        onIterationEvent.Subscribe(OnIteration);
        current = 0;
    }
    public int Current() => current;
    public void OnIteration()
    {
        current++;
    }
}