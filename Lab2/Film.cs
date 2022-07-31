using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
        //Свойство, возвращающее функцию от полей
        public string TextForWritting
        {
            get
            {
                return $"{_id};{_name};{_year};{_country};{_genre}; {_duration}; {_feesInTheWorld}";
            }
        }
        //Метод, который выводит информацию об объекте на экран
        public void PrintInfo()
        {
            Console.WriteLine($"{_id} {_name} Год: {_year} Страна: {_country} Жанр: {_genre} " +
                $"Продолжительность: {_duration} минут(-ы) Сборы в мире: ${_feesInTheWorld}");
        }
        //Переопределение метода ToString()
        public override string ToString()
        {
            return $"\nКод фильма = {_id} \nНазвание фильма = {_name} \nГод = {_year} \nСтрана = {_country} \nЖанр = {_genre} " +
                $"\nПродолжительность = {_duration} минут(-ы) \nСборы в мире = ${_feesInTheWorld}";
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
        //Конструктор с параметром типа строки
        public Film(string str)
        {
            string[] s = str.Split(';');

            try {_id = int.Parse(s[0]);} catch {_id = 0;}
            try { _name = s[1]; } catch { _name = "Фильм без названия"; }
            try { _year = s[2]; } catch { _year = "Год не указан"; }
            try { _country = s[3]; } catch { _country = "Страна не указана"; }
            try { _genre = s[4]; } catch { _genre = "Жанр не указан"; }
            try { _duration = int.Parse(s[5]); } catch { _duration = -1; }
            try { _feesInTheWorld = int.Parse(s[6]); } catch { _feesInTheWorld = -1; }

        }

    }
}
