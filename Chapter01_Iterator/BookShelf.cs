using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_1;
public class BookShelf : IAggregate
{
    private Book[] Books;

    private int Last = 0;

    public BookShelf(int maxsize)
    {
        Books = new Book[maxsize];
    }

    public Book this[int index]
    {
        get
        {
            return Books[index];
        }
    }

    public void AppendBook(Book book)
    {
        Books[Last] = book;
        Last++;
    }

    public int GetLength()
    {
        return Last;
    }

    public IIterator Iterator()
    {
        return new BookShelfIterator(this);
    }
}
