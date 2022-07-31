namespace Chapter17_Observer_1;
public class GraphObserver : IObserver
{
    public void Update(NumberGenerator generator)
    {
        var count = generator.GetNumber();

        for (var i = 0; i < count; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        Thread.Sleep(100);
    }
}
