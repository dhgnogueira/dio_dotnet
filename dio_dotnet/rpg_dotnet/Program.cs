using System;
namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
        }
    }
}