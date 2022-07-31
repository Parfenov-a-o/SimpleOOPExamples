using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Serial:Movie
    {
        //Количество сезонов сериала
        int _seasonCount;
        //Список годов выпуска сезонов сериала
        public List<string> SeasonReleaseYears { get; set; } = new List<string>();

        public int SeriesCount
        {
            get { return _seasonCount; }
            set { _seasonCount = value; }
        }
        //Конструктор без параметра
        public Serial()
        {
            _seasonCount = 0;
        }
        //Параметрический конструктор, принимающий список годов выпуска сезонов
        public Serial(int id, string t, string c, int sC, List<string> sRY):base(id,t,c)
        {
            _seasonCount = sC;
            SeasonReleaseYears = sRY;
        }
        //Параметрический конструктор, без списка годов выпуска сезонов
        public Serial(int id, string t, string c, int sC) : base(id, t, c)
        {
            _seasonCount = sC;
        }

        //Переопределение метода, который выводит информацию об объекте на экран
        public override void PrintInfo()
        {
            Console.WriteLine($"{Id} {Title} Страна: {Country} Количество сезонов: {_seasonCount} Года выпуска сезонов: ");
            foreach(var item in SeasonReleaseYears)
            {
                Console.WriteLine(item);
            }
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            string s = "";
            s+= $"\nКод = {Id} \nНазвание сериала = {Title} \nСтрана = {Country} \nКоличество сезонов = {_seasonCount} \nГода выпуска сезонов:";
            foreach(var item in SeasonReleaseYears)
            {
                s += $"\n{item}";
            }
            return s;
        }
        //Метод для добавления нового сезона сериала
        public void AddSeason(string year)
        {
            SeasonReleaseYears.Add(year);
            _seasonCount++;
        }


    }
}
