using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1_1
{
    internal class CD
    {
        public string Название { get; set; }
        public int Объем { get; set; }

        public CD(string name)
        {
            Название = name;
            Объем = 1400;
        }

        public override string ToString()
        {
            return $"{Название} Объем:{Объем}";
        }
    }
}
