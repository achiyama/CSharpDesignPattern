using System;

namespace Chapter05_Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");

            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            } 
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }

            Console.WriteLine("End.");

            Ex1();
        }

        /// <summary>
        /// 練習問題
        /// </summary>
        public static void Ex1()
        {
            Console.WriteLine("Ex1 Start.");
            for (int i = 0; i < 9; i++)
            {
                var triple = Triple.GetInstance(i % 3);
                Console.WriteLine(i + ": " + triple);
            }
            Console.WriteLine("Ex2 End.");
        }
    }
}
