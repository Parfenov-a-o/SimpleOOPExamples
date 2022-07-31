using Lab3_1;
Console.WriteLine("Добро пожаловать в лабораторную работу №3");
Actor _actor1 = new Actor(0, "Александр", "Михайлов", new DateOnly(1944,10,5));
Actor _actor2 = new Actor(1, "Нина", "Дорошина", new DateOnly(1934,12,3));
Actor _actor3 = new Actor(2, "Людмила", "Гурченко", new DateOnly(1935,11,12));
Actor _actor4 = new Actor(3, "Александр", "Демьяненко", new DateOnly(1937,05,30));
Actor _actor5 = new Actor(4, "Юрий", "Яковлев", new DateOnly(1928,04,25));
Actor _actor6 = new Actor(5, "Наталья", "Крачковская", new DateOnly(1938,11,24));
List<Actor> _actrsList1 = new List<Actor>();
_actrsList1.Add(_actor1);
_actrsList1.Add(_actor2);
_actrsList1.Add(_actor3);

List<Actor> _actrsList2 = new List<Actor>();
_actrsList2.Add(_actor4);
_actrsList2.Add(_actor5);
_actrsList2.Add(_actor6);

Film[] films = new Film[2];
films[0] = new Film(1, "Любовь и голуби", "1984", "СССР", 
    "мелодрама, комедия", 107, -1, _actrsList1);
films[1] = new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", 
    "комедия, фантастика, приключения", 88, -1, _actrsList2);

Console.WriteLine("\nВывод информации об объектах с помощью переопределенного метода ToString():");
Console.WriteLine($"{films[0]}\n{films[1]}");

string str = "";
for (int i = 0; i < films.Length; i++)
{
    if (i > 0)
    {
        str += "\n";
    }
    str += films[i].TextForWritting;
}

File.WriteAllText("Файл для записи.txt", str);
Console.WriteLine("\nМассив объектов успешно записан в файл!");


string[] readingLinesFromFile = File.ReadAllLines("Файл для записи.txt");
Film[] readingFilmsFromFile = new Film[readingLinesFromFile.Length];
Console.WriteLine("\nСчитанные из файла объекты:");
for (int i = 0; i < readingLinesFromFile.Length; i++)
{
    readingFilmsFromFile[i] = new Film(readingLinesFromFile[i]);
    Console.WriteLine(readingFilmsFromFile[i]);
}
Console.WriteLine("\nМассив объектов успешно загружен из файла!");
Console.WriteLine("\nЗавершение лабораторной работы №3");

