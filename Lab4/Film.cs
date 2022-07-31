using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Film:Movie
    {
        //Год выпуска
        string _year;
        //Жанр
        string _genre;
        //Продолжительность
        int _duration;
        //Сборы в мире
        int _feesInTheWorld;

        //Свойство для чтения и для изменения
        public string Year
        {
            get { return _year; }
            set { _year = value; }
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


        //Пустой конструктор без параметров
        public Film()
        {
            _year = "Год не указан";
            _genre = "Жанр не указан";
            _duration = -1;
            _feesInTheWorld = -1;
        }
        //Конструктор с параметрами для инициализации полей
        public Film(int id, string t, string y, string c, string g, int d, int f) : base(id,t,c)
        {
            _year = y;
            _genre = g;
            _duration = d;
            _feesInTheWorld = f;
        }


        //Переопределение метода, который выводит информацию об объекте на экран
        public override void PrintInfo()
        {
            Console.WriteLine($"{Id} {Title} Год: {_year} Страна: {Country} Жанр: {_genre} " +
                $"Продолжительность: {_duration} минут(-ы) Сборы в мире: ${_feesInTheWorld}");
        }
        //Переопределение метода ToString()
        public override string ToString()
        {
            return $"\nКод фильма = {Id} \nНазвание фильма = {Title} \nГод = {_year} \nСтрана = {Country} \nЖанр = {_genre} " +
                $"\nПродолжительность = {_duration} минут(-ы) \nСборы в мире = ${_feesInTheWorld}";
        }




    }
}
