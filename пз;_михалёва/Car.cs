using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз__михалёва
{
    internal class Car
    {
        private string _marka;
        private int _cilindr;
        private int _power;

        public Car(string marka, int cilindr, int power)
        {
            _marka = marka;
            _cilindr = cilindr;
            _power = power;
        }

        void Read()
        {
            Console.WriteLine("Укажите марку машины:");
            _marka = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите число цилиндров:");
            _cilindr = Convert.ToInt32(Console.Read());
            Console.WriteLine("Мощность:");
            _power = Convert.ToInt32(Console.Read());
        }

        void Display()
        {
            Console.WriteLine($"Марка:{_marka}");
            Console.WriteLine($"Число цилиндров: {_cilindr}");
            Console.WriteLine($"Мощность: {_power}");
        }
    }
}
