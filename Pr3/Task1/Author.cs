using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Task1
{
    public class Author
    {
        private string _authorName;

        public Author(string name)
        {
            _authorName = name;
        }

        public void Show()
        {
            Console.WriteLine($"Author: {_authorName}");
        }
    }
}
