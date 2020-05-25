using System;
using static System.Console;
namespace ConsoleAppProvision
{
    class Program
    {
        static void Main(string[] args)
        {
            MeatAndSteak meat = new MeatAndSteak();
            meat.Info += InfoShow;
            meat.Error += ErrorShow;

            meat.SteakPreparation(SteakType.Pork, DonenessType.Medium, 400);
        }
        static void InfoShow(string message) 
        {
            WriteLine(message);
        }
        static void ErrorShow(string message)
        {
            WriteLine(message);
        }

    }
}
