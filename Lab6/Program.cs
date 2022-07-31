using Lab6;

Console.WriteLine("Добро пожаловать в лабораторную работу №6");

Serial serial1 = new Serial(3, "Чернобыль: Зона отчуждения", "Россия", 2, 8, 48, new List<string> { "2014", "2017" });
Console.WriteLine(serial1);
serial1.IsFinished = true;
Console.WriteLine("\nПопытка добавить новый сезон в завершенный сериал.");
serial1.AddSeason("2018");
Console.WriteLine("\nВывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial1);

Console.WriteLine("\nДобавляем число просмотров к сериалу с помощью метода AddViews().");
serial1.AddViews(50);
Console.WriteLine("Вывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial1);
Console.WriteLine("\nИзменяем величину дохода от 1-ого просмотра.");
serial1.PayPerView = 10;
Console.WriteLine("Вывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial1);

Console.WriteLine("\nЗавершение лабораторной работы №6");