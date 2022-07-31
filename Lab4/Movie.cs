using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Movie
    {
        //Код ролика
        int _id;
        //Название ролика
        string _title;
        //Страна
        string _country;

        //Свойство для чтения
        public int Id
        {
            get { return _id; }

        }
        //Свойство для чтения
        public string Title
        {
            get { return _title; }

        }
        //Свойство для чтения и для изменения
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        //Метод, который выводит информацию об объекте на экран
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{_id} {_title} Страна: {_country} ");
        }
        //Переопределение метода ToString()
        public override string ToString()
        {
            return $"\nКод ролика = {_id} \nНазвание ролика = {_title} \nСтрана = {_country}";
        }
        //Пустой конструктор без параметров
        public Movie()
        {
            _id = 0;
            _title = "Без названия";
            _country = "Страна не указана";
        }
        //Конструктор с параметрами для инициализации полей
        public Movie(int id, string t, string c)
        {
            _id = id;
            _title = t;
            _country = c;
        }
    }
}
