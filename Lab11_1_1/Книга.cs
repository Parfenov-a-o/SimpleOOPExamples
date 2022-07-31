using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1_1
{
    internal class Книга
    {
        public string Название { get; set; }
        public Книга(string name)
        {
            Название = name;
        }
        public override string ToString()
        {
            return Название;
        }
    }
}
