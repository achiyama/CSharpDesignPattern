namespace Chapter12_Decorator;

public class Program
{
    public static void Main()
    {
        var b1 = new StringDisplay("Hello, World.");
        var b2 = new SideBorder(b1, '#');
        var b3 = new FullBorder(b2);

        b1.Show();
        b2.Show();
        b3.Show();

        var b4 = new SideBorder(new FullBorder(new FullBorder(new SideBorder(new FullBorder(new StringDisplay("こんにちは")), '*'))), '/');
        b4.Show();
    }
}
