using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз__михалёва
{
    internal class Lorry: Car
    {
        private int _gruzopodemnost;

        public Lorry(string marka, int cilindr, int power, int gruzopodemnost) :
            base(marka, cilindr, power)
        {
            _gruzopodemnost = gruzopodemnost;
        }

        void Read()
        {
            Console.WriteLine("Грузоподъёмность:");
            _gruzopodemnost = Convert.ToInt32(Console.Read());
        }

        void Display()
        {
            Console.WriteLine($"Грузоподъёмность : {_gruzopodemnost}");
        }

        public int PereznachenieGruzopodemnosti(Lorry lorry) 
        {
            Console.WriteLine($"Грузоподъёмность : {lorry._gruzopodemnost}");
            int NovayaGruzopodemnost = Convert.ToInt32(Console.ReadLine());
            return lorry._gruzopodemnost = NovayaGruzopodemnost;
            Console.WriteLine($"Грузоподъёмность : {lorry._gruzopodemnost}");
        }
    }
}
