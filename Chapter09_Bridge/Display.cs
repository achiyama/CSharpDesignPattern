using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09_Bridge
{
    /// <summary>
    /// 機能のクラスの最上位
    /// </summary>
    public class Display
    {
        /// <summary>
        /// 実装のクラスの最上位(シンプルに表示する)
        /// </summary>
        private DisplayImpl _impl;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="impl"></param>
        public Display(DisplayImpl impl)
        {
            _impl = impl;
        }

        public void Open()
        {
            _impl.RawOpen();
        }

        public void Print()
        {
            _impl.RawPrint();
        }

        public void Close()
        {
            _impl.RawClose();
        }

        /// <summary>
        /// シンプルに表示する
        /// </summary>
        public void SimpleDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
