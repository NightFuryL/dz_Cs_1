using System;
using dz_Cs_1.Exercise1;//Файл із классом CreditCard для другого завдання
//Над другим завданням працював старанно та додав багато всього іншого:) 
namespace dz_Cs_1;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #region Exercise 1
        //1.1 - 1.3
        Action showTime = () => Console.WriteLine(DateTime.Now.ToLongTimeString());
        Action showDate = () => Console.WriteLine(DateTime.Now.ToShortDateString());
        Action showDay = () => Console.WriteLine(DateTime.Now.DayOfWeek);
        //1.4 - 1.5
        Func<double, double, double> TriangleArea = (a, h) => (a * h) / 2;
        Func<double, double, double> RectArea = (a, b) => a * b;
        //1.6 я його додав щоб був приклад із Predicate бо в завданні його не було
        Predicate<int> isEven = x => x % 2 == 0;

        showTime();
        showDate();
        showDay();
        Console.WriteLine(TriangleArea(10, 5));
        Console.WriteLine(RectArea(4, 6));
        Console.WriteLine(isEven(10));
        #endregion

        #region Exercise 2
        var card = new CreditCard(
            "1234 5678 9999 0000",
            "Богля Лев",
            new DateTime(2000, 4, 7),
            1234,
            5000,
            2000
        );
        /*Або так можна зробити через лямбда вирази я залишив щоб було декіклька прикладів
        card.OnDeposit += msg => Console.WriteLine("[Deposit] " + msg);
        card.OnWithdraw += msg => Console.WriteLine("[Withdraw] " + msg);
        card.OnCreditStart += msg => Console.WriteLine("[Credit] " + msg);
        card.OnTargetReached += msg => Console.WriteLine("[Target] " + msg);
        card.OnPinChanged += msg => Console.WriteLine("[PIN] " + msg);*/
        //так ще такий приклад через СТАТИЧНИЙ метод класу
        card.OnDeposit += CreditCard.myLog;
        card.OnWithdraw += CreditCard.myLog;
        card.OnCreditStart += CreditCard.myLog;
        card.OnTargetReached += CreditCard.myLog;
        card.OnPinChanged += CreditCard.myLog;
        card.OnShowInfo += CreditCard.myLog;
        Console.WriteLine("Console: " + card.Info());
        
        card.Deposit(3000);
        card.Withdraw(6000);
        card.ChangePin(9999);

        Console.WriteLine("Console: " + card.Info());
        Console.WriteLine("Reading logs:\n");
        CreditCard.ReadLogs();
        #endregion
    }
}
