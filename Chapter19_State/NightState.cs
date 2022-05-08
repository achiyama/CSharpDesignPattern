using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter19_State
{
    /// <summary>
    /// 夜間の状態を表すクラス
    /// </summary>
    public class NightState : IState
    {
        private static IState _singleton = new NightState();

        private NightState()
        {
        }

        public static IState GetInstance()
        {
            return _singleton;
        }

        /// <summary>
        /// 時刻設定
        /// </summary>
        /// <param name="context">コンテキスト</param>
        /// <param name="hour">時間</param>
        public void DoClock(Context context, int hour)
        {
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            } 
        }

        /// <summary>
        /// 金庫使用
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoUse(Context context)
        {
            context.CallSecurityCenter("非常:夜間の金庫使用！");
        }

        /// <summary>
        /// 非常ベル
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("非常ベル:(夜間)");
        }

        /// <summary>
        /// 通常通話
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoPhone(Context context)
        {
            context.CallSecurityCenter("通常の通話(昼間)");
        }

        /// <summary>
        /// 文字列表現
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[昼間]";
        }
    }
}
