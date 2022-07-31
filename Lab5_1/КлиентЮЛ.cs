using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class КлиентЮЛ:Клиент
    {
        decimal _общаяСуммаПлатежей;
        public decimal ОбщаяСуммаПлатежей
        {
            get
            {
                return _общаяСуммаПлатежей;
            }
            set
            {
                if(value>0)
                {
                    _общаяСуммаПлатежей = value;
                }
                else
                {
                    _общаяСуммаПлатежей = 0;
                }
                
            }
        }
        public КлиентЮЛ(int код, string наим, decimal сумма_платежей):base(код, наим)
        {
            ОбщаяСуммаПлатежей = сумма_платежей;
        }
        public override decimal Скидка()
        {
            if (ОбщаяСуммаПлатежей > 10000000)
                return 0.15m;
            else if (ОбщаяСуммаПлатежей > 5000000)
                return 0.1m;
            else if (ОбщаяСуммаПлатежей > 2000000)
                return 0.05m;
            else
                return 0;
        }
        public override decimal Долг()
        {
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() +
                "\n Общая сумма платежей=" +
                ОбщаяСуммаПлатежей.ToString();
        }

        public override string КлассКлиента()
        {
            if (ОбщаяСуммаПлатежей > 10000000)
                return "A";
            else if (ОбщаяСуммаПлатежей > 5000000)
                return "B";
            else if (ОбщаяСуммаПлатежей > 2000000)
                return "С";
            else
                return "D";
        }
    }
}
