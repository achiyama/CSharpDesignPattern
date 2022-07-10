using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_2;
public class Program
{
    /**
     * .NETでIteratorパターンを実装する場合は
     * 以下を利用する
     * 
     * ・IAggregate → IEnumerable
     * ・IIterator  → IEnumerator
     */
    public static void Main() {
        var bookShelf = new BookShelf();
        bookShelf.AppendBook(new Book("Around the World in 80 days"));
        bookShelf.AppendBook(new Book("Bible"));
        bookShelf.AppendBook(new Book("Cinderella"));
        bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

        foreach (var book in bookShelf)
        {
            Console.WriteLine(book.GetName());
        }
    }
}
