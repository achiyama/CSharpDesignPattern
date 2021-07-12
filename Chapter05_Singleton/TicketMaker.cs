using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter05_Singleton
{
    /// <summary>
    /// 静的クラスでシングルトン
    /// </summary>
    public static class TicketMaker
    {
        private static int ticket = 1000;

        public static int GetNextTicketNumber()
        {
            return ticket++;
        }
    }
}
