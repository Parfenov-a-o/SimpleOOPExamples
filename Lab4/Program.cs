using Lab4;

Console.WriteLine("Добро пожаловать в лабораторную работу №4");

Movie movie1 = new Movie(0, "Танцы котов и собак", "Австралия");
Console.WriteLine("\nВывод информации о ролике с помощью метода ToString():");
Console.WriteLine(movie1);
Console.WriteLine("\nВывод информации о ролике с помощью метода PrintInfo():");
movie1.PrintInfo();
Film film1 = new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107, -1);
Console.WriteLine("\n\nВывод информации о фильме с помощью метода ToString():");
Console.WriteLine(film1);
Console.WriteLine("\nВывод информации о фильме с помощью метода PrintInfo():");
film1.PrintInfo();
Serial serial1 = new Serial(2,"Мажор", "Россия", 0);
Console.WriteLine("\n\nВывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial1);
Console.WriteLine("\nДобавление сезонов в сериал.");
serial1.AddSeason("2014");
serial1.AddSeason("2016");
serial1.AddSeason("2018");
serial1.AddSeason("2022");
Console.WriteLine("\nВывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial1);
Console.WriteLine("\nЗавершение лабораторной работы №4");
