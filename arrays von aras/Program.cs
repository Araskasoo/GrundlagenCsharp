using System;

namespace arrays_von_aras
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int Summe = 0;
            int[] noten = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Geben Sie die {i} Note ein :");
                noten[i] = Convert.ToInt32(Console.ReadLine());
                Summe = Summe + noten[i];
            }

            for (int index = 0; index < noten.Length; index++)
            {
                Console.WriteLine(noten[index]);

            }

            Console.WriteLine("ihr durchschnitt ist :");
            Console.WriteLine(Summe / n);
            
        }
    }
}

