using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1_2_List
{
    public class Товар
    {
        private int код;
        private string название;
        private string описание;
        private decimal цена;
        public override string ToString()
        {
            return string.Format(" {0} \n Цена {1}, Цена со скидкой {2} \n{3}", this.НазваниеПолное, this.Цена, this.Цена-this.Скидка,this.ОписаниеКраткое);
        }
        Товар(int код1, string название1, decimal цена1, string описание1)
        {
            this.код = код1;
            this.название = название1;
            this.цена = цена1;
            this.описание = описание1;
        }
        public Товар()
        {

        }
        public int Код
        {
            get
            {
                return this.код;
            }
            set
            {
                this.код = value;
            }
        }
        public string Название
        {
            get
            {
                return this.название;
            }
            set
            {
                this.название = value;
            }
        }
        public string НазваниеПолное
        {
            get
            {
                return string.Format(" {0} : {1}", this.код, this.название
               );
            }
        }
        public decimal Цена
        {
            get
            {
                return this.цена;
            }
            set
            {
                this.цена = value;
            }
        }
        public decimal Скидка
        {
            get
            {
                return 0.1m * this.цена;
            }
        }
        public string ОписаниеПолное
        {
            get
            {
                return this.описание;
            }
            set
            {
                this.описание = value;
            }
        }
        public string ОписаниеКраткое
        {
            get
            {
                if (this.ОписаниеПолное.Length > 100)
                    return this.ОписаниеПолное.Substring(0, 100);
                else
                    return this.ОписаниеПолное;
            }
        }
    }
}
