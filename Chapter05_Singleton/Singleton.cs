using System;

namespace Chapter05_Singleton
{
    public class Singleton
    {
        private static Singleton _singleton = new Singleton();
        
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton GetInstance()
        {
            return _singleton;
        }
    }
}
