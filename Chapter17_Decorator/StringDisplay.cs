using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Decorator
{
    /// <summary>
    /// 1行だけからなる文字列表示用のクラス
    /// </summary>
    public class StringDisplay : Display
    {
        /// <summary>
        /// 表示文字列
        /// </summary>
        private string _string;

        public StringDisplay(string str)
        {
            _string = str;
        }

        public override int GetColumns()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            var length = sjisEnc.GetByteCount(_string);
            return length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return _string;
            }

            return null;
        }
    }
}
