using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_1;
public class Program
{
    public static void Main()
    {
        var bookShelf = new BookShelf(4);
        bookShelf.AppendBook(new Book("Around the World in 80 days"));
        bookShelf.AppendBook(new Book("Bible"));
        bookShelf.AppendBook(new Book("Cinderella"));
        bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

        var it = bookShelf.Iterator();

        while (it.HasNext())
        {
            var book = (Book)it.Next();
            Console.WriteLine(book.GetName());
        }
    }
}
