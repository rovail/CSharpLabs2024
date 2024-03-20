using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3.Task1
{
    public class Content
    {
        private string _content;

        public Content(string content)
        {
            _content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Content: {_content}");
        }
    }
}
