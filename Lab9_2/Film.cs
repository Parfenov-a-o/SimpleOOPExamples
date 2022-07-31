using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_2
{
    internal class Film
    {
        //Код фильма
        int _id;
        //Название фильма
        string _name;
        //Год выпуска
        string _year;
        //Страна
        string _country;
        //Жанр
        string _genre;
        //Продолжительность
        int _duration;
        //Сборы в мире
        int _feesInTheWorld;

        //Свойство для чтения
        public int Id
        {
            get { return _id; }

        }
        //Свойство для чтения
        public string Name
        {
            get { return _name; }

        }
        //Свойство для чтения и для изменения
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        //Свойство для чтения и для изменения
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        //Свойство для чтения и для изменения
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }

        }
        //Свойство для чтения и для изменения
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        //Свойство для чтения и для изменения
        public int FeesInTheWorld
        {
            get { return _feesInTheWorld; }
            set { _feesInTheWorld = value; }
        }
        //Метод, который выводит информацию об объекте на экран
        public string PrintInfo()
        {
            return $"Код фильма = {_id} \nНазвание фильма = {_name} \nГод = {_year} \nСтрана = {_country} \nЖанр = {_genre} " +
                $"\nПродолжительность = {_duration} минут(-ы) \nСборы в мире = ${_feesInTheWorld}";
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            return $"{Name}";
        }
        //Пустой конструктор без параметров
        public Film()
        {

        }
        //Конструктор с параметрами для инициализации полей
        public Film(int id, string n, string y, string c, string g, int d, int f)
        {
            _id = id;
            _name = n;
            _year = y;
            _country = c;
            _genre = g;
            _duration = d;
            _feesInTheWorld = f;
        }

    }
}
