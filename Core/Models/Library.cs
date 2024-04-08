using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Library
    {
        public Library() 
        {

        }

        Book[] Books = new Book[] { };
        public void Book (Book book)
        {

            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
        public void FindAllBooksByName(string name)
        {
            Book[] Books = { };
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    Array.Resize(ref Books, Books.Length+1);
                    Books[Books.Length-1]= book;
                }
            } return Book;
        }

        public void RemoveAllBooks(string Name )
        {
            Book[] Books = { };
            foreach (Book book in Books)
            {
                Array.Resize(ref Books, Books.Length + 1);
                Books[Books.Length - 1] = book;
            }
            Books = Books;
        }
        public void SeachBook(string Name, int No, string AuthorName, int PageCount)
        {

            Book[] Books = { };



        }
    }

 


}
