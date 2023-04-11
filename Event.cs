public class Event : IEvent
{
    List<EventDelegate> methods = new List<EventDelegate>();
    public void Subscribe(EventDelegate method) => methods.Add(method);
    public void Call()
    {
        foreach(var method in methods)
        {
            method();
        }
    }
}
public delegate void EventDelegate();