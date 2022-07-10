using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_1;
public class Book
{
    private string Name;

    public Book(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}
