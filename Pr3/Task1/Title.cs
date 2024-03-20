using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Task1
{
    public class Title
    {
        private string _title;

        public Title(string title)
        {
            _title = title;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {_title}");
        }
    }
}
