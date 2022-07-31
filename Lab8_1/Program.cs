using Lab8_1;

Console.WriteLine("Добро пожаловать в лабораторную работу №8");
Actor<DateOnly> _actor1 = new Actor<DateOnly>(0, "Александр", "Михайлов", new DateOnly(1944, 10, 5));
Actor<DateOnly> _actor2 = new Actor<DateOnly>(1, "Нина", "Дорошина", new DateOnly(1934, 12, 3));
Actor<DateOnly> _actor3 = new Actor<DateOnly>(2, "Людмила", "Гурченко", new DateOnly(1935, 11, 12));
Actor<string> _actor4 = new Actor<string>(3, "Александр", "Демьяненко", "1937.05.30");
Actor<string> _actor5 = new Actor<string>(4, "Юрий", "Яковлев", "1928.04.25");
Actor<string> _actor6 = new Actor<string>(5, "Наталья", "Крачковская", "1938.11.24");
List<Actor<DateOnly>> _actrsList1 = new List<Actor<DateOnly>>();
_actrsList1.Add(_actor1);
_actrsList1.Add(_actor2);
_actrsList1.Add(_actor3);

List<Actor<string>> _actrsList2 = new List<Actor<string>>();
_actrsList2.Add(_actor4);
_actrsList2.Add(_actor5);
_actrsList2.Add(_actor6);

Film<string,DateOnly,string> film1 = new Film<string,DateOnly,string>(1, "Любовь и голуби", "1984", "СССР",
    "мелодрама, комедия", 107, -1, _actrsList1);
Film<int, string, GenresEnum> film2 = new Film<int, string, GenresEnum>(2, "Иван Васильевич меняет профессию", 1973, "СССР",
    GenresEnum.Comedy, 88, -1, _actrsList2);
Console.WriteLine("\nВывод информации об объектах с помощью переопределенного метода ToString():");
Console.WriteLine($"{film1}\n{film2}");

Film<string, string, GenresEnum> film3 = new Film<string, string, GenresEnum>(3, "Один дома", "1990", "США",
    GenresEnum.Comedy, 103, 476684675);
Actor<string> _actor7 = new Actor<string>(6, "Маколей", "Калкин", "1980.08.26");
Actor<string> _actor8 = new Actor<string>(7, "Джо", "Пеши", "1943.02.09");
Actor<string> _actor9 = new Actor<string>(8, "Дэниел", "Стерн","1957.08.28");

film3.Actors.Add(_actor7);
film3.Actors.Add(_actor8);
film3.Actors.Add(_actor9);

Console.WriteLine("\nВывод информации о фильме с помощью переопределенного метода ToString():");
Console.WriteLine(film3);

List<Actor<string>> actors = film3.GetActorsWhoAgeLess18();
Console.WriteLine("\nАктёры фильма, которым на момент съемок было меньше 18 лет:");
foreach (Actor<string> actor in actors)
{
    Console.WriteLine(actor);
}

Console.WriteLine("\nЗавершение лабораторной работы №8");


