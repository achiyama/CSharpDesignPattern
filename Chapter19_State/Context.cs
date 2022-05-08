using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter19_State
{
    /// <summary>
    /// 状態管理
    /// </summary>
    public interface Context
    {
        /// <summary>
        /// 時刻の設定
        /// </summary>
        /// <param name="hour">時間</param>
        void SetClock(int hour);

        /// <summary>
        /// 状態変化
        /// </summary>
        /// <param name="state">状態</param>
        void ChangeState(IState state);

        /// <summary>
        /// 警備センター呼び出し
        /// </summary>
        /// <param name="msg">メッセージ</param>
        void CallSecurityCenter(string msg);

        /// <summary>
        /// 警備センター記録
        /// </summary>
        /// <param name="msg">メッセージ</param>
        void RecordLog(string msg);
    }
}
