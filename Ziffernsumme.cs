using System;

namespace Ziffernsumme
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;
            int sum = 0;
            string input;

            do
            {
                sum = 0;
                Console.Write("Bitte Zahl eingeben: ");
                number = Convert.ToInt32(Console.ReadLine());

                while (number != 0)                     //Solange wiederholen bis number 0 ist
                {
                    int digit = number % 10;            //es wird die letzte Zahl in digit gespeichert

                    sum = sum + digit;                  //Summe wird durch die digit erhöht
                    number = number / 10;               //Damit die Zahl nicht mehrfach zur Summe gezählt wird wird die letzte Zahl gelöscht
                }

                Console.WriteLine("Die Summe der Ziffern ist {0}!", sum);
                Console.Write("Möchtest du nochmal? <ja/nein>: ");
                input = Console.ReadLine().ToLower();            
            } while (input == "ja");                    //Solange wiederholen bis user nicht "ja" eingibt
        }
    }
}
