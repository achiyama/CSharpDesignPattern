using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter05_Singleton
{
    public class Triple
    {
        public static List<Triple> Triples { get; set; } = new List<Triple>()
        {
            new Triple(0),
            new Triple(1),
            new Triple(2)
        };

        public int Id { get; set; }

        private Triple(int id)
        {
            Console.WriteLine("The Instance " + id + " is created.");
            Id = id;
        }

        public static Triple GetInstance(int id)
        {
            if (id < 0 && 3 < id)
            {
                return null;
            }

            return Triples[id];
        }

        public override string ToString()
        {
            return "[Triple Id=" + Id + "]";
        }
    }
}
