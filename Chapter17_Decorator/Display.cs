using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17_Decorator
{
    /// <summary>
    /// 文字列表示用の抽象クラス
    /// </summary>
    public abstract class Display
    {
        /// <summary>
        /// 横の文字数を得る
        /// </summary>
        /// <returns></returns>
        public abstract int GetColumns();

        /// <summary>
        /// 縦の行数を得る
        /// </summary>
        /// <returns></returns>
        public abstract int GetRows();

        /// <summary>
        /// row番目の文字列を得る
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public abstract string GetRowText(int row);

        /// <summary>
        /// 全部表示する
        /// </summary>
        public void Show()
        {
            for (var i = 0; i < GetRows(); i++)
            {
                Console.WriteLine(GetRowText(i));
            } 
        }
    }
}
