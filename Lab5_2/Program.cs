using Lab5_2;

Console.WriteLine("Добро пожаловать в лабораторную работу №5");

Serial serial1 = new Serial(2, "Мажор", "Россия", 0, 10, 52);
serial1.AddSeason("2014");
serial1.AddSeason("2016");
serial1.AddSeason("2018");
serial1.AddSeason("2022");
Console.WriteLine("\nВывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial1);


Serial serial2 = new Serial(3, "Чернобыль: Зона отчуждения", "Россия", 2, 8, 48, new List<string> {"2014", "2017" });
Console.WriteLine("\nВывод информации о сериале с помощью метода ToString():");
Console.WriteLine(serial2);
Console.WriteLine("\nЗавершение лабораторной работы №5");