using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Decorator
{
    /// <summary>
    /// 左右のみに飾り枠をつける
    /// </summary>
    public class SideBorder : Border
    {
        /// <summary>
        /// 飾りとなる文字
        /// </summary>
        private char _borderChar;

        public SideBorder(Display display, char ch) : base(display)
        {
            _borderChar = ch;
        }

        public override int GetColumns()
        {
            return 1 + _display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return _display.GetRows();
        }

        public override string GetRowText(int row)
        {
            return _borderChar +  _display.GetRowText(row) + _borderChar;
        }
    }
}
