using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    //Класс "Сериал"
    internal class Serial
    {
        //Код
        int _id;
        //Название
        string _title;
        //Страна-производитель
        string _country;
        //Жанр
        string _genre;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string Genre
        {
            get => _genre;
            set => _genre = value;
        }

        //Список сезонов
        public List<Season> Seasons { get; set; } = new List<Season>();

        //Параметрический конструктор
        public Serial(int id, string t, string c, string g)
        {
            Id = id;
            Title = t;
            Country = c;
            Genre = g;
            
        }
        //Переопределение метода ToString() для вывода информации о сериале на экран
        public override string ToString()
        {
           
            string s = $"\nНазвание сериала: \"{Title}\" \nСтрана: {Country} \nЖанр: {Genre} \nКоличество сезонов: {Seasons.Count} \nАктеры:";
            List<Actor> actors = Seasons.SelectMany(s => s.Episodes).SelectMany(e=>e.Actors).Distinct().ToList();
            foreach(var actor in actors)
            {
                s +=  $"\n{actor}";
            }
            return s;
        }
        //Выбрать актёров сериала, которы старше 30 лет
        public void SelectActorsOver30Years()
        {
            Console.WriteLine("\nОтобразить актёров, которые старше 30 лет:");
            List<Actor> actors = Seasons.SelectMany(s => s.Episodes).SelectMany(e => e.Actors).Distinct().
                Where(a=>(DateTime.Now.Year - a.BirthDate.Year)>30).ToList();
            foreach(var actor in actors)
            {
                Console.WriteLine(actor);
            }
        }




    }
}
