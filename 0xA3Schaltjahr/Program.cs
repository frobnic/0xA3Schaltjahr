using System;

namespace _0xA3Schaltjahr
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;

            Console.WriteLine("Bitte geben sie ein Jahr ein");
            if (int.TryParse(Console.ReadLine(), out j))
            {
                Console.WriteLine("");
                if (j % 4 != 0)
                    Console.Write("Kein ");
                else
                {
                    if (j % 100 == 0)
                        if (j % 400 != 0)
                            Console.Write("Kein ");
                }
                Console.WriteLine("Schaltjahr");
            }
        }
    }
}
