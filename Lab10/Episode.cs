using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    //Класс "Серия"
    internal class Episode
    {
        //Номер серии
        public int Id { get; set; }
        //Название
        public string Title { get; set; }
        //Продолжительность
        public int Duration { get; set; }
        //Список актёров
        public List<Actor> Actors { get; set; } = new List<Actor>();
        //Параметрический конструктор
        public Episode(int id, string t, int d)
        {
            Id = id;
            Title = t;
            Duration = d;
        }

    }
}
