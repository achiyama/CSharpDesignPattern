using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09_Bridge
{
    /// <summary>
    /// 機能のクラス階層(指定回数だけ表示する)
    /// </summary>
    public class CountDisplay : Display
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="impl"></param>
        public CountDisplay(DisplayImpl impl) 
            : base(impl)
        {

        }

        /// <summary>
        /// 指定回数だけ表示する
        /// </summary>
        /// <param name="times"></param>
        public void MultiDisplay(int times)
        {
            Open();
            for (int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
