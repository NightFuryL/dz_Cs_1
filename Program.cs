using System;
using dz_Cs_1.ClassesAndStructures;
using dz_Cs_1.Overload;

namespace dz_Cs_1;


class Program
{
    static void Main()
    {
        #region Класи та структури дз(15.11.2025 - 22.11.2025)
        Website w = new Website();
        w.Input("Google", "https://google.com", "Search engine", "3.3.3.3");
        w.Print();
        Journal j = new Journal();
        j.Input("Forbes", 1923, "News magazine", "123456", "forbes@mail.com");
        j.Print();
        Shop s = new Shop();
        s.Input("Allo", "Main Street 5", "Electronics", "987654", "allo@mail.com");
        s.Print();
        #endregion
        #region Класи. Структури. Перевантаження операторів. Методи розширення. Записи дз(16.11.2025 - 23.11.2025)
        BookList list = new BookList();
        list += "Harry Potter";
        list += "Metro 2033";
        list += "Witcher";
        list -= "Metro 2033";
        Console.WriteLine(list == "Game of Thrones");
        Console.WriteLine(list != "Harry Potter");
        Console.WriteLine(list[0]);
        list.Print();
        Fraction a = new Fraction(1, 2);
        Fraction b = new Fraction(3, 4);
        Fraction c = a + b;
        Fraction d = a * b;
        Fraction e = b - a;
        Fraction f = b / a;
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(a == new Fraction(1, 2));
        #endregion
    }
}
