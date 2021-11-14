using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09_Bridge
{
    public class Program
    {
        public static void Main()
        {
            var d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            var d2 = new Display(new StringDisplayImpl("Hello, World."));
            var d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            d1.SimpleDisplay();
            d2.SimpleDisplay();
            d3.SimpleDisplay();
            d3.MultiDisplay(5);
        }
    }
}
