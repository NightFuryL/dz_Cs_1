using System;

namespace dz_Cs_1.Overload
{
    internal class BookList//Зробив із лістами)
    {
        List<string> books = new List<string>();
        public int Count
        {
            get { return books.Count; }
        }
        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        public static BookList operator +(BookList list, string book)
        {
            list.books.Add(book);
            return list;
        }
        public static BookList operator -(BookList list, string book)
        {
            list.books.Remove(book);
            return list;
        }
        public static bool operator ==(BookList a, string book)
        {
            return a.books.Contains(book);
        }
        public static bool operator !=(BookList a, string book)
        {
            return !a.books.Contains(book);
        }
        public void Print()
        {
            for (int i = 0; i < books.Count; i++)
                Console.WriteLine(books[i]);
        }
    }
    internal class Fraction
    {
        int n;
        int d;
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public int D
        {
            get { return d; }
            set { d = value == 0 ? 1 : value; }
        }
        public Fraction(int n, int d)
        {
            this.n = n;
            this.d = d == 0 ? 1 : d;
            Reduce();
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return Math.Abs(a);
        }

        public void Reduce()//Цей метод для скорочення дробу
        {
            int g = GCD(n, d);
            n /= g;
            d /= g;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.n * b.d + b.n * a.d, a.d * b.d);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.n * b.d - b.n * a.d, a.d * b.d);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.n * b.n, a.d * b.d);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.n * b.d, a.d * b.n);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.n == b.n && a.d == b.d;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return $"{n}/{d}";
        }
    }

}
