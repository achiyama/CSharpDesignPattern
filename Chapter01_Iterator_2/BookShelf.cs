using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_Iterator_2;
public class BookShelf : IEnumerable<Book>
{
    private readonly List<Book> _books = new List<Book>();

    public int Length => _books.Count;

    public void AppendBook(Book book)
    {
        _books.Add(book);
    }

    public Book this[int index]
    {
        get
        {
            return _books[index];
        }
    }

    public int GetLength()
    {
        return _books.Count;
    }

    /// <summary>
    /// イテレーターブロック
    /// </summary>
    /// <returns></returns>
    public IEnumerator<Book> GetEnumerator()
    {
        foreach (var book in _books)
        {
            yield return book;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
