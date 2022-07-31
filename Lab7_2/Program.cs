using Lab7_2;

Console.WriteLine("Добро пожаловать в лабораторную работу №7");

Film film1 = new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107);
Film film2 = new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", "комедия, фантастика, приключения", 88);

Console.WriteLine("\nИнформация о созданных объектах типа Film:");
Console.WriteLine(film1);
Console.WriteLine(film2);

Console.WriteLine("\nПример использования перегрузки операторов \">\" и \"<\":");
if(film1>film2)
{
    Console.WriteLine($"Фильм \"{film1.Name}\" старше фильма \"{film2.Name}\"!");
}
else
{
    Console.WriteLine($"Фильм \"{film2.Name}\" старше фильма \"{film1.Name}\"!");
}


Film film3 = new Film(3, "Трансформеры", "2007", "США", "фантастика, боевик", 143);
Film film4 = new Film(4, "Трансформеры: Месть падших", "2009", "США", "фантастика, боевик", 149);
Film film5 = new Film(5, "Трансформеры 3: Темная сторона Луны", "2011", "США", "фантастика, боевик", 154);

Console.WriteLine("\nПример использования перегруженного оператора сложения:");
FilmSeries filmSeries1 = film3 + film4;
Console.WriteLine(filmSeries1);
Console.WriteLine("\nДобавление нового фильма в серию фильмов:");
filmSeries1.FilmParts.Add(film5);
Console.WriteLine(filmSeries1);

FilmSeries filmSeries2 = (FilmSeries)film3;
Console.WriteLine("\nПример использования перегруженного оператора явного преобразования:");
Console.WriteLine(filmSeries2);
Console.WriteLine("\nЗавершение лабораторной работы №7");



