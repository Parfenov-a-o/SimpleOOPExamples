using Lab11_2_1;

Console.WriteLine("Добро пожаловать в лабораторную работу №11\n");
Console.WriteLine("Создание объекта типа FilmCollection.");
FilmCollection collection1 = new FilmCollection();
Console.WriteLine("Вывод информации о коллекции с помощью цикла foreach:");
foreach(Film f in collection1)
{
    Console.WriteLine(f);
}
Console.WriteLine("\nВывод информации о коллекции с помощью цикла for:");
for (int i = 0; i < collection1.Kolvo; i++)
{
    Console.WriteLine($"\n i= {i} {collection1[i]}");
}
Console.WriteLine("\nСоздание коллекции с помощью метода GetCollection.");
var collection2 = GetCollection();
Console.WriteLine("Вывод информации о коллекции с помощью цикла foreach:");
foreach (Film f in collection2)
{
    Console.WriteLine(f);
}
Console.WriteLine("\nЗавершение лабораторной работы №11");

static System.Collections.IEnumerable GetCollection()
{
    yield return new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107, -1);
    yield return new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", "комедия, фантастика, приключения", 88, -1);
    yield return new Film(3, "Москва слезам не верит", "1979", "СССР", "мелодрама, драма, комедия", 150, 2516245);
    yield return new Film(4, "Бриллиантовая рука", "1968", "СССР", "комедия, криминал", 94, -1);
    yield return new Film(5, "Свадьба в Малиновке", "1967", "СССР", "мюзикл, комедия, военный", 95, -1);
    yield return new Film(6, "Экипаж", "1979", "СССР", "боевик, триллер, драма", 135, -1);
    yield return new Film(7, "...А зори здесь тихие", "1972", "СССР", "драма, военный, история", 160, -1);

}
