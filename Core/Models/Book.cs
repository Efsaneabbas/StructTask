using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Book
    {
        public static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
         

        public Book()
        {

        }

        public Book(string name,  string authorName, int pageCount)
        {
            _no++;
            No = _no ;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;

        }

    }
}
