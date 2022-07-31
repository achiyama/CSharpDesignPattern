namespace Chapter17_Observer_2;

public class RandomNumberGenerator : IObservable<NumberGenerator>
{
    private IList<IObservable<NumberGenerator>> _observers;

    public RandomNumberGenerator()
    {
        _observers = new List<IObservable<NumberGenerator>>();
    }

    public IDisposable Subscribe(IObserver<NumberGenerator> observer)
    {
        throw new NotImplementedException();
    }
}
