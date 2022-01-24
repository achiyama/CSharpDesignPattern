using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Decorator
{
    /// <summary>
    /// 飾り枠クラス
    /// </summary>
    public abstract class Border : Display
    {
        /// <summary>
        /// 中身
        /// </summary>
        protected Display _display;

        protected Border(Display display)
        {
            _display = display;
        }
    }
}
