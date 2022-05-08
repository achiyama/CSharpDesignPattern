using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter19_State
{
    /// <summary>
    /// 昼間の状態を表すクラス
    /// </summary>
    public class DayState : IState
    {
        private static IState _singleton = new DayState();

        private DayState()
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
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }
        
        /// <summary>
        /// 金庫使用
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoUse(Context context)
        {
            context.RecordLog("金庫使用(昼間)");
        }

        /// <summary>
        /// 非常ベル
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("非常ベル(昼間)");
        }

        /// <summary>
        /// 通常通話
        /// </summary>
        /// <param name="context">コンテキスト</param>
        public void DoPhone(Context context)
        {
            context.CallSecurityCenter("通常の通話(昼間)");
        }
    }
}
