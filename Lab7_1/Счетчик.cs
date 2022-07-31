using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    internal class Счетчик
    {
        public int Величина
        {
            get;
            set;
        }
        public string Наименование
        { get; set; }
        public static explicit operator int (Счетчик a)
        {
            return a.Величина;
        }
        public static explicit operator Счетчик(int i)
        {
            Счетчик a = new Счетчик() { Величина = i, Наименование = "" };
            return a;
        }
        public override string ToString()
        {
            return "Счетчик: " + this.Величина; 
        }
        public static Счетчик operator +(Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина + b.Величина;
            return c;
        }
        //Добавление перегрузки оператора "-"
        public static Счетчик operator -(Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина - b.Величина;
            return c;
        }
        //Добавление перегрузки оператора "*"
        public static Счетчик operator *(Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина * b.Величина;
            return c;
        }

        //Добавление перегрузки оператора "/"
        public static Счетчик operator /(Счетчик a, Счетчик b)
        {
            Счетчик c = new Счетчик();
            c.Величина = a.Величина / b.Величина;
            return c;
        }

        //Добавление перегрузки оператора "true"
        public static bool operator true(Счетчик a)
        {
            return (a.Величина >= 0);
        }
        //Добавление перегрузки оператора "false"
        public static bool operator false(Счетчик a)
        {
            return (a.Величина < 0);
        }


        public static bool operator < (Счетчик a, Счетчик b)
        {
            return (a.Величина < b.Величина);
        }
        public static bool operator > (Счетчик a, Счетчик b)
        {
            return (a.Величина > b.Величина);
        }
        public static Счетчик operator ++(Счетчик a)
        {
            Счетчик x = new Счетчик() { Величина = a.Величина++ };
            return x;
        }
        public static Счетчик operator --(Счетчик a)
        {
            Счетчик x = new Счетчик() { Величина = a.Величина-- };
            return x;
        }
    }
}
