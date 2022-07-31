namespace Chapter17_Observer_2;

/// <summary>
/// 数の生成を表すオブジェクトを表す抽象クラス
/// </summary>
public abstract class NumberGenerator
{
    private List<IObserver> _observers = new();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void DeleteObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public abstract int GetNumber();

    public abstract void Execute();
}
