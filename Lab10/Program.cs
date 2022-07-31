using Lab10;

Console.WriteLine("Добро пожаловать в лабораторную работу №10");

//Создание массива объектов "Serial"
Serial[] russianSerials = new Serial[1];

//Создание конкретного сериала
russianSerials[0] = new Serial(1,"Чернобыль: Зона отчуждения", "Россия", "триллер, фантастика");

//Создание массива объектов типа "Actor"
Actor[] actrsSerial1 = new Actor[] 
{
    new Actor(1,"Константин", "Давыдов", "Россия", new DateOnly(1990,07,20)),
    new Actor(2, "Сергей", "Романович", "Россия", new DateOnly(1992, 07, 16)),
    new Actor(3, "Анвар", "Халилулаев", "Россия", new DateOnly(1995, 02, 21)),
    new Actor(4, "Кристина", "Казинская", "Россия", new DateOnly(1989, 10, 3))
};

//Создание массива объектов типа "Episode" (все серии 1-ого сезона)
Episode[] episodesSerial1 = new Episode[] 
{
    new Episode(1, "Сон, деньги и Чернобыль", 48),
    new Episode(2, "Беглец", 48),
    new Episode(3, "Граница", 48),
    new Episode(4, "Охота", 48),
    new Episode(5, "Бункер", 48),
    new Episode(6, "Там", 48),
    new Episode(7, "КГБ СССР", 48),
    new Episode(8, "ЧП в четвертом блоке", 48)
};

//Добавление актёров каждой серии
foreach(var episode in episodesSerial1)
{
    episode.Actors.AddRange(actrsSerial1);
}

//Создание объекта типа "Season" (1-ый сезон сериала)
Season s1 = new Season(1, 2014);
//Добавление списка серий в сезон
s1.Episodes.AddRange(episodesSerial1);

//Добавление сезона в сериал
russianSerials[0].Seasons.Add(s1);

Console.WriteLine("Вывод информации об объекте на экран с использованием анонимного делегата:");
//Использование анонимного метода
PrintInfo print=delegate ()
{
    Console.WriteLine(russianSerials[0]);
};
//Вызов делегата
print();
//Использование встроенного делегата Func
Func<int> totalSeasonDuration = russianSerials[0].Seasons[0].TotalSeasonDuration;
//Вызов делегата Func
Console.WriteLine($"Продолжительность 1-ого сезона: {totalSeasonDuration()} минут(-ы)");

Console.WriteLine("Общая продолжительность сериала:");
//Использование встроенного делегата Action
Action printTotalDuration = () => Console.WriteLine($"{russianSerials[0].Seasons.SelectMany(s=>s.Episodes).Sum(e=>e.Duration)} минут(-ы)");
//Вызов делегата Action
printTotalDuration();

//Добавление к делегату метода "SelectActorsOver30Years"
print += russianSerials[0].SelectActorsOver30Years;
//Добавление к делегату лямбда-выражения
print += () =>
{
    Console.WriteLine("\nОтобразить актёров с именем \"Константин\":");
    List<Actor> actors = russianSerials[0].Seasons.SelectMany(s => s.Episodes).SelectMany(e => e.Actors).Distinct().
        Where(a => a.Name == "Константин").ToList();
    foreach (var actor in actors)
    {
        Console.WriteLine(actor);
    }
};
Console.WriteLine("\nДемонстрация реализации группового делегата. \nВызов делегата после добавления в него двух методов.");
//Вызов группового делегата
print();

Console.WriteLine("\nЗавершение лабораторной работы №10");

//объявление делегата типа void и не принимающего параметров
delegate void PrintInfo();


