using System;

namespace dz_Cs_1.ClassesAndStructures
{
    internal class Website
    {
        string? name;
        string? url;
        string? description;
        string? ip;

        public void Input(string name, string url, string description, string ip)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ip = ip;
        }

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(url);
            Console.WriteLine(description);
            Console.WriteLine(ip);
        }

        public string GetName() { return name; }
        public void SetName(string v) { name = v; }
    }
    internal class Journal
    {
        string? name;
        int year;
        string? description;
        string? phone;
        string? email;

        public void Input(string name, int year, string description, string phone, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(year);
            Console.WriteLine(description);
            Console.WriteLine(phone);
            Console.WriteLine(email);
        }

        public string GetName() { return name; }
        public void SetName(string v) { name = v; }
    }
    internal class Shop
    {
        string? name;
        string? address;
        string? description;
        string? phone;
        string? email;

        public void Input(string name, string address, string description, string phone, string email)
        {
            this.name = name;
            this.address = address;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(description);
            Console.WriteLine(phone);
            Console.WriteLine(email);
        }

        public string GetName() { return name; }
        public void SetName(string v) { name = v; }
    }
}
