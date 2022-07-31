using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск формы!");
            //Создание объекта класса "Form"
            OurForm form = new OurForm();
            //Отображение формы на экране
            form.ShowDialog();

        }
    }
}
