using System;

namespace AnwendungsSchicht.FizzBuzz
{
    public class FizzBuzzer
    {
        //private string _ausgabe;
        public string MacheFizzBuzzVon1Bis100()
        {
            string ausgabe = "";
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                    ausgabe += AddFizz();
                if (i % 5 == 0)
                    ausgabe += AddBuzz();
                if (i % 3 != 0 && i % 5 != 0)
                    ausgabe += AddZahl(i);
                
                ausgabe += AddLeerzeichen();
            }
            return ausgabe;
        }

        private String AddZahl(int i)
        {
            return i.ToString();
        }

        private string AddLeerzeichen()
        {
            return " ";
        }

        private string AddBuzz()
        {
            return "Buzz";
        }

        private string AddFizz()
        {
            return "Fizz";
        }
    }
}