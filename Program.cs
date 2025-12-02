using System;
using dz_Cs_1.Exercise1;


class Program
{
    static void Main()
    {
        #region HW 29.11.2025 - 06.12.2025
        //1
        Book b1 = new Book { Title = "B1", Author = "AB1", Year = 2000, Pages = 150 };
        b1.Show();
        b1.Dispose();
        Book b2 = new Book { Title = "B2", Author = "AB2", Year = 1999, Pages = 300 };
        b2 = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
        //2
        using (Library lib = new Library())
        {
            lib.Add(new Book { Title = "Game Of Thrones", Author = "George R. R. Martin", Year = 1996, Pages = 333 });
            lib.Add(new Book { Title = "Meditations", Author = "Mark Aurelius", Year = 100, Pages = 333 });
            lib.ShowAll();
        }
        #endregion
    }
}
