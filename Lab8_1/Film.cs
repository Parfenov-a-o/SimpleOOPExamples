using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    //Обобщенный класс, который принимает три параметра типа
    internal class Film<T,V,Z>
    {
        //Код фильма
        int _id;
        //Название фильма
        string _name;
        //Год выпуска
        T _year;
        //Страна
        string _country;
        //Жанр
        Z _genre;
        //Продолжительность
        int _duration;
        //Сборы в мире
        int _feesInTheWorld;
        //Список актёров фильма
        public List<Actor<V>> Actors { get; set; } = new List<Actor<V>>();
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
        public T Year
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
        public Z Genre
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

        //Переопределение метода ToString()
        public override string ToString()
        {
            string s = "";
            s += $"\nКод фильма = {_id} \nНазвание фильма = {_name} \nГод = {_year} \nСтрана = {_country} \nЖанр = {_genre} " +
                $"\nПродолжительность = {_duration} минут(-ы) \nСборы в мире = ${_feesInTheWorld} \nВ главных ролях:";

            foreach (var item in Actors)
            {
                s += $"\n{item}";
            }
            return s;
        }
        //Пустой конструктор без параметров
        public Film()
        {

        }
        //Конструктор с параметрами для инициализации полей
        public Film(int id, string n, T y, string c, Z g, int d, int f)
        {
            _id = id;
            _name = n;
            _year = y;
            _country = c;
            _genre = g;
            _duration = d;
            _feesInTheWorld = f;
        }

        //Конструктор с параметрами для инициализации полей со списком актёров
        public Film(int id, string n, T y, string c, Z g, int d, int f, List<Actor<V>> actrs)
        {
            _id = id;
            _name = n;
            _year = y;
            _country = c;
            _genre = g;
            _duration = d;
            _feesInTheWorld = f;
            Actors = actrs;
        }
        //Метод, который возвращает список актёров, возраст которых на момент выхода фильма был меньше 18 лет
        public List<Actor<V>> GetActorsWhoAgeLess18()
        {
            List<Actor<V>> actrs = new List<Actor<V>>();
            foreach (var actor in Actors)
            {

                if (((typeof(T) == typeof(int))|| (typeof(T) == typeof(string)))&&((typeof(V) == typeof(DateOnly)) || (typeof(V) == typeof(string))))
                {
                    if((Convert.ToInt32(Year) - Convert.ToDateTime(actor.BirthDate).Year) < 18)
                    {
                        actrs.Add(actor);
                    }
                }

            }
            return actrs;
        }

    }
}
