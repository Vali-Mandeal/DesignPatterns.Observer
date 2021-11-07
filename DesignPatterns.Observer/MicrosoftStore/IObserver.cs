namespace DesignPatterns.Observer.MicrosoftStore
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
