using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_1.Exercise1
{
    internal class Library : IDisposable
    {
        public Book[] Books = new Book[10];
        int index = 0;

        public void Add(Book b)
        {
            if (index < Books.Length)
                Books[index++] = b;
        }

        public void ShowAll()
        {
            for (int i = 0; i < index; i++)
                Books[i].Show();
        }

        public void Dispose()
        {
            Console.WriteLine("Library's dispose");
            Books = null;
        }
    }
}
