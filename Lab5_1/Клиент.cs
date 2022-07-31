using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    abstract class Клиент
    {
        int _код;
        string _наимен;
        public int Код
        {
            get
            {
                return _код;
            }
            set
            {
                if(value >= 0)
                {
                    _код = value;
                }
                else
                {
                    _код = -1;
                }

            }
        }
        public string Наимен
        {
            get
            { 
                if(_наимен.Length>15)
                {
                    return _наимен.Substring(0,15);
                }
                return _наимен; 
            }
            set 
            {
                _наимен = value; 
            }
        }

        public Клиент()
        { }
        public Клиент (int код, string наим)
        {
            _код = код;
            _наимен = наим;
        }
        public void ПечатьКарточки()
        {
            Console.WriteLine("\nКарточка №{0} \nНаименование={1} \nЗадолженность={2} \nСкидка={3} \nКласс клиента={4}", Код, Наимен,Долг(),Скидка(),КлассКлиента());
        }
        abstract public decimal Долг();
        abstract public decimal Скидка();
        abstract public string КлассКлиента();
        public override string ToString()
        {
            return String.Format("Код= {0} Наименование={1}", Код, Наимен);
        }
    }
}
