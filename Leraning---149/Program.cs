using System;
using System.IO;

namespace Leraning___149
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zyski ze sprzedazy płytek drukownaych");
            while (true)
            {
                try
                {
                    Calc();
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Calc()
        {
            Console.WriteLine("Wprowadź cenne detalicznych płytek:");
            double price = double.Parse(Console.ReadLine());

            double profits = price * 0.4;
            Console.WriteLine($"Zysk ze sprzedazy wynoi {profits.ToString("c")}");
            StreamWriter inputDate = File.CreateText("Zysk.text");
            inputDate.WriteLine($"Zysk ze sprzedazy wynoi {profits.ToString("c")}");
            inputDate.Close();
        }
    }
}
