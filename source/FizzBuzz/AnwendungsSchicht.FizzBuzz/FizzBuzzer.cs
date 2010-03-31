using System;

namespace AnwendungsSchicht.FizzBuzz
{
    public class FizzBuzzer
    {
        private string _ausgabe;
        public string MacheFizzBuzzVon1Bis100()
        {
            _ausgabe = "";
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                    AddFizz();
                if (i % 5 == 0)
                    AddBuzz();
                if (i % 3 != 0 && i % 5 != 0)
                    AddZahl(i);
                AddLeerzeichen();
            }
            return _ausgabe;
        }

        private void AddZahl(int i)
        {
            _ausgabe += i;
        }

        private void AddLeerzeichen()
        {
            _ausgabe += " ";
        }

        private void AddBuzz()
        {
            _ausgabe += "Buzz";
        }

        private void AddFizz()
        {
            _ausgabe += "Fizz";
        }
    }
}