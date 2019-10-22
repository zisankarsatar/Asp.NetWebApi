using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Mavi :IRenk
    {
        public void Doldur()
        {
            Console.WriteLine("Mavi::Doldur() metodu çalıştı");
        }
    }
}
