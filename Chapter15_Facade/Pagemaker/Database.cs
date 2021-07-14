using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Chapter15_Facade.Pagemaker
{
    public class Database
    {
        private Database()
        {
            
        }

        public static Dictionary<string, string> GetProperties(string dbname)
        {
            string filename = dbname + ".txt";
            var result = new Dictionary<string, string>();

            using (var file = new StreamReader("./" + filename))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    var arrayLine = line.Split("=").ToArray();
                    result.Add(arrayLine[0], arrayLine[1]);
                }
            }

            return result;
        }
    }
}
