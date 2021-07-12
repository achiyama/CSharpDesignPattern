using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07_Builder
{
    /// <summary>
    /// 一つの文章を作るクラス
    /// </summary>
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.MakeTitle("Greeting");
            _builder.MakeString("朝から夜にかけて");
            _builder.MakeItems(new string[]
            {
                "おはようございます。",
                "こんにちは。"
            });
            _builder.MakeString("夜に");
            _builder.MakeItems(new string[]
            {
                "こんばんは。",
                "おやすみなさい。",
                "さようなら。"
            });
            _builder.Close();
        }
    }
}
