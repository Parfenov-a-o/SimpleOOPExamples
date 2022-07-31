using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
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
        //Список актёров фильма
        List<Actor> Actors { get; set; } = new List<Actor>();
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
                string s = "";
                s+= $"{_id};{_name};{_year};{_country};{_genre}; {_duration}; {_feesInTheWorld} |";

                for(int i = 0; i < Actors.Count; i++)
                {
                    if(i==Actors.Count-1)
                    {
                        s += Actors[i].TextForWritting;
                    }
                    else
                    {
                        s += Actors[i].TextForWritting + "/";
                    }

                }    
                return s;
            }
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            string s = "";
            s+= $"\nКод фильма = {_id} \nНазвание фильма = {_name} \nГод = {_year} \nСтрана = {_country} \nЖанр = {_genre} " +
                $"\nПродолжительность = {_duration} минут(-ы) \nСборы в мире = ${_feesInTheWorld} \nВ главных ролях:";
            
            foreach(var item in Actors)
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

        //Конструктор с параметрами для инициализации полей со списком актёров
        public Film(int id, string n, string y, string c, string g, int d, int f, List<Actor> actrs)
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
        //Конструктор с параметром типа строки
        public Film(string str)
        {
            string[] s = str.Split('|');

            string[] filmInfo = s[0].Split(';');
            try { _id = int.Parse(filmInfo[0]); } catch { _id = 0; }
            try { _name = filmInfo[1]; } catch { _name = "Фильм без названия"; }
            try { _year = filmInfo[2]; } catch { _year = "Год не указан"; }
            try { _country = filmInfo[3]; } catch { _country = "Страна не указана"; }
            try { _genre = filmInfo[4]; } catch { _genre = "Жанр не указан"; }
            try { _duration = int.Parse(filmInfo[5]); } catch { _duration = -1; }
            try { _feesInTheWorld = int.Parse(filmInfo[6]); } catch { _feesInTheWorld = -1; }

            string [] actorInfo = s[1].Split('/');
            foreach(var item in actorInfo)
            {
                Actors.Add(new Actor(item));
            }

        }

    }
}
