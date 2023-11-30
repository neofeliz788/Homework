using System;
using System.Collections.Generic;

namespace Tumakov
{
    internal class BookContainer
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void SortBooks(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }

        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Издатель: {book.Publisher}");
            }
        }
    }
}