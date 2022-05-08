using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter19_State
{
    public interface IState
    {
        /// <summary>
        /// 時刻設定
        /// </summary>
        void DoClock(Context context, int hour);

        /// <summary>
        /// 金庫使用
        /// </summary>
        void DoUse(Context context);

        /// <summary>
        /// 非常ベル
        /// </summary>
        void DoAlarm(Context context);

        /// <summary>
        /// 通常通話
        /// </summary>
        void DoPhone(Context context);
    }
}
