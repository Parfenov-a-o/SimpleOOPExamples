using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    internal class Serial:Movie
    {
        //Количество сезонов сериала
        int _seasonCount;
        //Количество серий в сезоне
        int _episodeInSeasonCount;
        //Продолжительность одной серии
        int _episodeDuration;

        public int EpisodeInSeasonCount
        {
            get { return _episodeInSeasonCount; }
            set { _episodeInSeasonCount = value; }
        }

        public int EpisodeDuration
        {
            get { return _episodeDuration; }
            set { _episodeDuration = value; }
        }
        //Список годов выпуска сезонов сериала
        public List<string> SeasonReleaseYears { get; set; } = new List<string>();

        public int SeasonCount
        {
            get { return _seasonCount; }
            set { _seasonCount = value; }
        }
        //Конструктор без параметра
        public Serial()
        {
            _seasonCount = 0;
            _episodeInSeasonCount = 0;
            _episodeDuration = 0;
        }
        //Параметрический конструктор, принимающий список годов выпуска сезонов
        public Serial(int id, string t, string c, int sC, int episInSC, int episDur, List<string> sRY) : base(id, t, c)
        {
            _seasonCount = sC;
            _episodeInSeasonCount = episInSC;
            _episodeDuration = episDur;
            SeasonReleaseYears = sRY;
        }
        //Параметрический конструктор, без списка годов выпуска сезонов
        public Serial(int id, string t, string c, int sC,int episInSC, int episDur) : base(id, t, c)
        {
            _seasonCount = sC;
            _episodeInSeasonCount = episInSC;
            _episodeDuration = episDur;

        }

        //Переопределение метода, который выводит информацию об объекте на экран
        public override void PrintInfo()
        {
            Console.WriteLine($"{Id} {Title} Страна: {Country} Количество сезонов: {_seasonCount} Года выпуска сезонов: ");
            foreach (var item in SeasonReleaseYears)
            {
                Console.WriteLine(item);
            }
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            string s = "";
            s += $"\nКод = {Id} \nНазвание сериала = {Title} \nСтрана = {Country} \nКоличество сезонов = {_seasonCount}" +
                $"\nПродолжительность {Duration()} минут \nВозраст: {Age()} лет \nГода выпуска сезонов:";
            foreach (var item in SeasonReleaseYears)
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
        //Подсчет продолжительности сериала
        public override int Duration()
        {
            return _episodeDuration * _episodeInSeasonCount * _seasonCount;
        }
        //Подсчет возраста сериала
        public override int Age()
        {
            if(_seasonCount>0)
            {
                return Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(SeasonReleaseYears[0]); 
            }
            return 0;
        }
    }
}
