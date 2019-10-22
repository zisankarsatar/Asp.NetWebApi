using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Kirmizi : IRenk
    {
        public void Doldur()
        {
            Console.WriteLine("Kırmızı::Doldur() metodu çalıştı.");
        }
    }
}
