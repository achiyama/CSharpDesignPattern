using System;
using System.Text;

namespace Chapter03_TemplateMethod
{
    /// <summary>
    /// メソッドOepn, Print, Closeを実装しているクラス
    /// </summary>
    public class StringDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示すべき文字列
        /// </summary>
        private string _str;

        /// <summary>
        /// 文字列の幅
        /// </summary>
        private int _width;

        public StringDisplay(string str)
        {
            _str = str;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _width = Encoding.GetEncoding("shift_jis").GetByteCount(str);
        }

        protected override void Open()
        {
            PrintLine();
        }

        protected override void Print()
        {
            Console.WriteLine("|" + _str + "|");
        }

        protected override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");

            for (var i = 0; i < _width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("+");
        }
    }
}
