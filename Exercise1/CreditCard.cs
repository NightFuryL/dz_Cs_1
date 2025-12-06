using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_1.Exercise1
{
    internal class CreditCard
    {
        public string? CardNumber;
        public string? Owner;
        public DateTime ExpireDate;
        public int Pin;
        public double creditLimit;
        public double Money;

        public event Action<string,string>? OnDeposit;
        public event Action<string,string>? OnWithdraw;
        public event Action<string,string>? OnCreditStart;
        public event Action<string,string>? OnTargetReached;
        public event Action<string,string>? OnPinChanged;
        public event Action<string, string>? OnShowInfo;
        //public event Action<string>? OnCreateAccount; 

        public double TargetSum = 10000;
        public CreditCard(string? number, string? owner, DateTime expire, int pin, double limit, double money)
        {
            CardNumber = number;
            Owner = owner;
            ExpireDate = expire;
            Pin = pin;
            creditLimit = limit;
            Money = money;
            //OnCreateAccount += myLog;
            //OnCreateAccount?.Invoke("Created a credit card: " + Info(), "CREATION");
            myLog("Created a credit card: " + Info(), "CREATION");//Або можна наприклад зробити лог при створенні картки за допомогою івенту OnCreateAccount
        }

        public void Deposit(double amount)
        {
            Money += amount;
            OnDeposit?.Invoke($"Deposit: +{amount}, balance: {Money}", "DEPOSIT");
            if (Money >= TargetSum)
                OnTargetReached?.Invoke($"Achieved amount: {Money}", "TARGET");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Money)
            {
                Money -= amount;
                OnWithdraw?.Invoke($"Withdrawn {amount}, balance: {Money}", "WITHDRAW");
            }
            else
            {
                double need = amount - Money;
                if (need <= creditLimit)
                {
                    creditLimit -= need;
                    Money = 0;
                    OnCreditStart?.Invoke($"Credit usage started. Withdrawn {amount}. Balance=0, limit={creditLimit}", "CREDIT");
                }
            }
        }

        public void ChangePin(int newPin)
        {
            Pin = newPin;
            OnPinChanged?.Invoke($"PIN changed to {newPin}", "PIN_CHANGE");
        }

        public string Info()
        {
            string info = $"\n\tCard: {CardNumber}, \n\tOwner: {Owner}, \n\tExpire: {ExpireDate.ToShortDateString()}, \n\tBalance: {Money}, \n\tCredit Limit: {creditLimit}";
            OnShowInfo?.Invoke("INFO" + info, "INFO");
            return info;
        }

        public static void myLog(string message,string typeLog)
        {
            string type = (message != null && message != "DEFAULT") ? $"{typeLog}" : "";
            string generelLogMessage = $"[LOG]({type}) - {message}";
            File.AppendAllBytes("credit_card_log.txt", Encoding.UTF8.GetBytes(generelLogMessage + Environment.NewLine));//ще додав зберігання логу в файл
            Console.WriteLine(generelLogMessage);
        }
        public static void ReadLogs()
        {
            if (File.Exists("credit_card_log.txt"))
            {
                string[] logEntries = File.ReadAllLines("credit_card_log.txt");
                foreach (var entry in logEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("Log file does not exist.");
            }
        }
    }
}
