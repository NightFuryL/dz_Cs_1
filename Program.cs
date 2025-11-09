using System;

class Program
{
    static void Main()
    {
        //1
        double t;
        int ch;
        Console.Write("Enter temperature : ");
        t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("1 - F to C");
        Console.WriteLine("2 - C to F");
        ch = Convert.ToInt32(Console.ReadLine());
        if (ch == 1)
        {
            t = (t - 32) * 5 / 9;
            Console.WriteLine("C : " + t);
        }
        else if (ch == 2)
        {
            t = t * 9 / 5 + 32;
            Console.WriteLine("F : " + t);
        }
        else
        {
            Console.WriteLine("incorrect choice!");
        }
        //2
        int a, b, i;
        Console.WriteLine("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("Even numbers in the range    :");
        for (i = a; i <= b; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
        //3
        int n, k = 0, s = 0, r;
        Console.Write("Enter a number : ");
        n = Convert.ToInt32(Console.ReadLine());
        int x = n;
        while (x > 0)
        {
            k++;
            x /= 10;
        }
        x = n;
        while (x > 0)
        {
            r = x % 10;
            int p = 1;
            int j = 0;
            while (j < k)
            {
                p = p * r;
                j++;
            }
            s = s + p;
            x = x / 10;
        }
        if (s == n)
            Console.WriteLine("This is an Armstrong number");
        else
            Console.WriteLine("Not an Armstrong number");
    }
}
