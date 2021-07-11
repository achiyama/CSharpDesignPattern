using System;

namespace Chapter03_TemplateMethod
{
    /// <summary>
    /// メソッドOpen, Print, Closeを実装しているクラス
    /// </summary>
    public class CharDisplay : AbstractDisplay
    {
        /// <summary>
        /// 表示すべき文字
        /// </summary>
        private char _ch;

        public CharDisplay(char ch)
        {
            _ch = ch;
        }

        protected override void Open()
        {
            Console.Write("<<");
        }

        protected override void Print()
        {
            Console.Write(_ch);
        }

        protected override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
