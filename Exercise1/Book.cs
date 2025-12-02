using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_1.Exercise1
{
    internal class Book : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        ~Book()
        {
            Console.WriteLine("Book's finalizer");
        }

        public void Dispose()
        {
            Console.WriteLine("Book's dispose");
            GC.SuppressFinalize(this);
        }

        public void Show()
        {
            Console.WriteLine($"{Title}, {Author}, {Year}, {Pages} pages");
        }
    }
}
