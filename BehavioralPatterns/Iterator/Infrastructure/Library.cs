using Iterator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Infrastructure
{
    public class Library : IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
            new Book{Name="Антихрупкость"},
            new Book {Name="Начни с почему"},
            new Book {Name="Анатомия заблуждения"}
            };
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public int Count
        {
            get { return books.Length; }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
