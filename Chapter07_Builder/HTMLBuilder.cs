using System;
using System.IO;
using System.Text;

namespace Chapter07_Builder
{
    /// <summary>
    /// HTMLファイルを使って文章を作るクラス
    /// </summary>
    public class HTMLBuilder : IBuilder
    {
        private string _fileName;
        private StreamWriter _sw;

        public void MakeTitle(string title)
        {
            _fileName = title + ".html";

            try
            {
                using var _sw = new StreamWriter(_fileName, false, Encoding.UTF8);
                _sw.WriteLine("<html><head><title>" + title + "</title></head><body>");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void MakeString(string str)
        {
            _sw.WriteLine("<h1>" + str + "</h1>");
        }

        public void MakeItems(string[] items)
        {
            _sw.WriteLine("<ul>");
            for (var i = 0; i < items.Length; i++)
            {
                _sw.WriteLine("<li>" + items[i] + "</li>");
            }
            _sw.WriteLine("</ul>");
        }

        public void Close()
        {
            _sw.WriteLine("</body></html>");
            _sw.Dispose();
        }

        public string GetResult() => _fileName;
    }
}
