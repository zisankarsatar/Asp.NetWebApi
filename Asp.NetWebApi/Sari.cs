using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Sari: IRenk
    {
        public void Doldur()
        {
            Console.WriteLine("Sari::Doldur() metodu çalıştı.");
        }
    }
}
