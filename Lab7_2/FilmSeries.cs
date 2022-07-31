using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    internal class FilmSeries
    {
        //Название серии фильмов
        string _title;

        public string Title
        { get { return _title; } set { _title = value; } }

        //Список фильмов, включенных в серию фильмов
        public List<Film> FilmParts { get; set; } = new List<Film>();
        //Параметрический конструктор
        public FilmSeries(string t)
        {
            _title = t;
        }
        //Переопределение метода ToString() для вывода информации об объекте на экран
        public override string ToString()
        {
            string s = $"\nНазвание серии фильмов: \"{Title}\" \nФильмы:";
            foreach(var item in FilmParts)
            {
                s += $"\n\"{item.Name}\" Продолжительность: {item.Duration} минут(-ы)";
            }
            s += $"\nОбщая продолжительность серии фильмов: {Duration()} минут(-ы)";
            return s;
        }

        //Подсчет общей продолжительности всей серии фильмов
        public int Duration()
        {
            return FilmParts.Sum(fp=>fp.Duration);
        }

    }
}
