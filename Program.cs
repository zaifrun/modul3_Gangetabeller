using System;

namespace Gangetabeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvilket tal vil du have gangetabeller op til?");
            int tal = Int32.Parse(Console.ReadLine());
            for (var i = 1; i <= tal; i++)
            {
                string tabel = "";
                for (var j = 1; j < 11; j++)
                {
                    tabel += i + "x" + j + " = " + i * j + " "; 
                }
                Console.WriteLine(tabel);
            }
        }
    }
}
