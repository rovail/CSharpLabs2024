using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Task1
{
    public class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public Book(string bookTitle, string authorName, string bookContent)
        {
            _title = new Title(bookTitle);
            _author = new Author(authorName);
            _content = new Content(bookContent);
        }

        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}
