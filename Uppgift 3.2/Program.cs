using System;

namespace Uppgift3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vi anställer! Har du gått ut ur gymnasiet? Svara enligt följande:");
            Console.WriteLine("j = Ja, n = Nej");
            string student = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (student == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig!");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
        }
    }
}