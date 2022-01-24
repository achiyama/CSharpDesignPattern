using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Decorator
{
    /// <summary>
    /// 上下左右に飾り枠をつけるクラス
    /// </summary>
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display)
        {
        }

        public override int GetColumns()
        {
            return 1 + _display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + _display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                // 枠の上端
                return "+" + MakeLine('-', _display.GetColumns()) + "+";
            }
            else if (row == _display.GetRows() + 1)
            {
                // 枠の下端
                return "+" + MakeLine('-', _display.GetColumns()) + "+";
            }
            else
            {
                // それ以外
                return "|" + _display.GetRowText(row - 1) + "|";
            }
        }

        /// <summary>
        /// 文字chをcount個連続させた文字列を作る
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private string MakeLine(char ch, int count)
        {
            var sb = new StringBuilder();
            
            for (var i = 0; i < count; i++)
            {
                sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
