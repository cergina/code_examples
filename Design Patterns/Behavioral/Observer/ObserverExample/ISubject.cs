namespace ObserverExample
{
    /// <summary>
    /// Observable aka Provider
    /// equivalent System.IObservable<T>
    /// </summary>
    public interface ISubject<T>
    {
        void Subscribe(IObserver<T> observer);

        void Unsubscribe(IObserver<T> observer);

        void Notify();
    }
}
