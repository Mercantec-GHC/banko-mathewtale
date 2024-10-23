using System.ComponentModel;
using System.Linq;



internal class Program
{
    private static void Main(string[] args)
    {
        int[,] BankoPlade1 = { { 1, 14, 42, 53, 83 }, { 15, 45, 56, 64, 87 }, { 19, 27, 39, 57, 78 } };
        int BankoTal;
        //bool Bankostop = false;
        do
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out BankoTal))
            {
                if (BankoTal >= 91 || BankoTal <= 0)
                {
                    Console.WriteLine("skriv et tal i mellem 1 og 90");

                }
                else if (Contains(BankoPlade1, BankoTal))
                {
                    Console.WriteLine($"{BankoTal} er på plade 1");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{BankoTal} er ikke på plade 1 ");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Ugyldig indtastning. Prøv venligst igen.");
                continue;
        }
        while (true);


            static bool Contains(int[,] array, int value)
            {
                foreach (var item in array)
                {
                    if (item == value)
                    {
                        return true;
                    }
                }
                return false;
            }

        } while (true);
    }
}