using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_2;
public class BookShelfEnumerator : IEnumerator<Book>
{
    private readonly BookShelf _bookShelf;

    private int _index = 0;

    public Book Current => _bookShelf[_index];

    object IEnumerator.Current => Current;

    public BookShelfEnumerator(BookShelf bookShelf)
    {
        _bookShelf = bookShelf;
    }

    public bool MoveNext()
    {
        _index++;
        return _index < _bookShelf.GetLength();
    }

    public void Reset()
    {
        _index = 0;
    }

    public void Dispose()
    {
    }
}
