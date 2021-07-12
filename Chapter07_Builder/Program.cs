using System;

namespace Chapter07_Builder
{
    /// <summary>
    /// 動作テスト用のクラス
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
                Environment.Exit(0);
            }

            if (args[0] == "plain")
            {
                var textBuilder = new TextBuilder();
                var director = new Director(textBuilder);
                director.Construct();
                var result = textBuilder.GetResult();
                Console.WriteLine(result);
            }
            else if (args[0] == "html")
            {
                var htmlBuilder = new HTMLBuilder();
                var director = new Director(htmlBuilder);
                director.Construct();
                var result = htmlBuilder.GetResult();
                Console.WriteLine(result + "が作成されました。");
            }
            else
            {
                Console.WriteLine("不正なコマンドライン引数です。");
                Environment.Exit(0);
            }
        }

        private static void Usage()
        {
            Console.WriteLine("plain プレーンテキストで文章作成");
            Console.WriteLine("html  HTMLファイルで文章作成");
        }
    }
}
