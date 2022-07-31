using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
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
        //Переопределение метода ToString()
        public override string ToString()
        {
            return $"\nКод фильма = {_id} \nНазвание фильма = {_name} \nГод = {_year} \nСтрана = {_country} \nЖанр = {_genre} " +
                $"\nПродолжительность = {_duration} минут(-ы)";
        }

        //Подсчет возраста фильма
        public int Age()
        {

                return Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(Year);
        }

        //Пустой конструктор без параметров
        public Film()
        {

        }
        //Конструктор с параметрами для инициализации полей
        public Film(int id, string n, string y, string c, string g, int d)
        {
            _id = id;
            _name = n;
            _year = y;
            _country = c;
            _genre = g;
            _duration = d;
        }

        //Перегрузка оператора "+"
        public static FilmSeries operator +(Film f1, Film f2)
        {
            FilmSeries filmSeries1 = new FilmSeries(f1.Name);
            filmSeries1.FilmParts.Add(f1);
            filmSeries1.FilmParts.Add(f2);
            return filmSeries1;
        }
        //Перегрузка оператора ">"
        public static bool operator >(Film f1, Film f2)
        {
            return (f1.Age() > f2.Age());
        }
        //Перегрузка оператора "<"
        public static bool operator <(Film f1, Film f2)
        {
            return (f1.Age() < f2.Age());
        }
        //Перегрузка оператора явного преобразования из типа Film в тип FilmSeries
        public static explicit operator FilmSeries(Film f1)
        {
            FilmSeries filmSeries1 = new FilmSeries(f1.Name);
            filmSeries1.FilmParts.Add(f1);
            return filmSeries1;
        }
        //Перегрузка оператора явного преобразования из типа Film в тип int
        public static explicit operator int(Film f1)
        {
            return f1.Duration;
        }

    }
}
