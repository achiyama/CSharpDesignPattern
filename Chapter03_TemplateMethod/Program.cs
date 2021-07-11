namespace Chapter03_TemplateMethod
{
    /// <summary>
    /// 動作テスト用のクラス
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var display1 = new CharDisplay('H');
            var display2 = new StringDisplay("Hello, World");
            var display3 = new StringDisplay("こんにちは");

            display1.Display();
            display2.Display();
            display3.Display();
        }
    }
}
