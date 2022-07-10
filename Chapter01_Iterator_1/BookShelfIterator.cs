using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_1;
public class BookShelfIterator : IIterator
{
    private BookShelf BookShelf;

    private int Index;

    public BookShelfIterator(BookShelf bookShelf)
    {
        BookShelf = bookShelf;
        Index = 0;
    }

    public bool HasNext()
    {
        return Index < BookShelf.GetLength();
    }

    public object Next()
    {
        var book = BookShelf[Index];
        Index++;
        return book;
    }
}
