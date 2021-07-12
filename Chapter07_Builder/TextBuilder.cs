using System.Text;

namespace Chapter07_Builder
{
    /// <summary>
    /// プレーンテキストを使って文章を作るクラス
    /// </summary>
    public class TextBuilder : IBuilder
    {
        private StringBuilder _sb = new StringBuilder();

        public void MakeTitle(string title)
        {
            _sb.Append("===================\n");
            _sb.Append("『" + title + "』\n");
            _sb.Append("\n");
        }
        public void MakeString(string str)
        {
            _sb.Append("■" + str + "\n");
            _sb.Append("\n");
        }
        public void MakeItems(string[] items)
        {
            for (var i = 0; i < items.Length; i++)
            {
                _sb.Append(" ・" + items[i] + "\n");
            }
        }

        public void Close() => _sb.Append("===================\n");

        public string GetResult() => _sb.ToString();
    }
}
