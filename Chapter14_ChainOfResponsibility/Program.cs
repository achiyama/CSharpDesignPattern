namespace Chapter14_ChainOfResponsibility;

public class Program
{
    static void Main(string[] args)
    {
        var alice = new NoSupport("Alice");
        var bob = new LimitSupport("Bob", 100);
        var charlie = new SpecialSupport("Charlie", 429);
        var diana = new LimitSupport("Diana", 200);
        var elmo = new OddSupport("Elmo");
        var fred = new LimitSupport("Fred", 300);

        alice
            .setNext(bob)
            .setNext(charlie)
            .setNext(diana)
            .setNext(elmo)
            .setNext(fred);

        for (var i = 0; i < 500; i++)
        {
            alice.Support(new Trouble(i));
        }
    }
}
