using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chapter15_Facade.Pagemaker
{
    public class HtmlWriter
    {
        private StreamWriter _sw;

        public HtmlWriter(StreamWriter streamWriter)
        {
            _sw = streamWriter;
        }

        public void Title(string title)
        {

        }
    }
}
