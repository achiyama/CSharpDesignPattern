namespace Chapter17_Observer_1;

public class Program
{
    public static void Main(string[] args)
    {
        var generator = new RandomNumberGenerator();
        var observer1 = new DigitObserver();
        var observer2 = new GraphObserver();
        generator.AddObserver(observer1);
        generator.AddObserver(observer2);
        generator.Execute();
    }
}
