using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt1
{
    class ClassIzd
    {
        public string Name;
        public string Shifr;
        public int Count;
        public ClassIzd(string n, string n1, int n2) { Name = n; Shifr = n1; Count = n2; }
        public void GetInfo()
        {
            Console.WriteLine($"Название: {Name} Шифр: {Shifr} Количество: {Count} ");
        }
    }
}
