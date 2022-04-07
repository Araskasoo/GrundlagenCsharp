using System;

namespace HotelGäste
{
    class Program
    {
        static void Main()
        {
            do
            {
                short[] zimmernummer = { 45, 23, 3, 32 };
                string[] vorname = { "John", "Paul", "George", "Ringo" };
                string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
                short[] übernachtung = { 1, 4, 12, 3 };
                double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };

                Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein");
                string eingabe_str = Console.ReadLine();
                short eingabe_short;

                bool flag = short.TryParse(eingabe_str, out eingabe_short);

                if (flag == false)
                {
                    var data = GetData(eingabe_str, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);
                }
                else
                {
                    var data = GetData(eingabe_short, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);

                }
            } while (true);


        }

        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {

            return ();
        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {

            return ();


            //von Aras und Mahmoud
        }
    }
}