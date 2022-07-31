namespace Chapter17_Observer_1;

public class DigitObserver : IObserver
{
    public void Update(NumberGenerator generator)
    {
        Console.WriteLine("DigitObserver: " + generator.GetNumber());

        Thread.Sleep(100);
    }
}
