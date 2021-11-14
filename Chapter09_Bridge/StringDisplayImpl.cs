using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09_Bridge
{
    /// <summary>
    /// 実装のクラス階層
    /// </summary>
    public class StringDisplayImpl : DisplayImpl
    {
        /// <summary>
        /// 表示する文字列
        /// </summary>
        private string _string;

        /// <summary>
        /// バイト単位で計算した文字列の「幅」
        /// </summary>
        private int _width;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="str"></param>
        public StringDisplayImpl(string str)
        {
            _string = str;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _width = Encoding.GetEncoding("shift_jis").GetByteCount(str);
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine("|" + _string + "|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
