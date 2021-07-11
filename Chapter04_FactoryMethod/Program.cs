using Chapter04_FactoryMethod.IdCard;

namespace Chapter04_FactoryMethod
{
    public class Program
    {
        public static void Main()
        {
            var factory = new IDCardFactory();
            var card1 = factory.Create("結城浩");
            var card2 = factory.Create("とむら");
            var card3 = factory.Create("佐藤花子");
            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
