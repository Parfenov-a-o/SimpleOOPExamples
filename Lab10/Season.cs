using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    //Класс "Сезон"
    internal class Season
    {
        //Код
        public int Id { get; set; }
        //Год выпуска
        public int Year { get; set; }
        //Список серий
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        //Параметрический конструктор
        public Season(int id, int y)
        {
            Id = id;
            Year = y;
        }
        //Подсчет продолжительности сезона
        public int TotalSeasonDuration()
        {
            return Episodes.Sum(e => e.Duration);
        }



    }

    
}
