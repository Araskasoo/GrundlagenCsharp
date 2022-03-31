using System;

namespace Methoden_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            


            {
                Console.WriteLine("Geben Sie einen Text ein");
                string eingabe_str = Console.ReadLine();
                Console.WriteLine("Geben Sie eine Zahl ein");
                int eingabe_int = Convert.ToInt32(Console.ReadLine());

                int anzahl = 0;
                anzahl = ausgabeTextMalX(eingabe_str, eingabe_int);



                Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);


            }
            static int ausgabeTextMalX(string s, int i)
            {

                for (int a = 0; a < i; a++)
                {

                    Console.WriteLine(s);
                }
                return i * s.Length;
            }

        }

        //von Mahmoud, Aras

    }

}

   