using Lab11_2_2;

Console.WriteLine("Добро пожаловать в лабораторную работу №11\n");

//Создание объектов типа "Film"
Film film1 = new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107, -1);
Film film2 = new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", "комедия, фантастика, приключения", 88, -1);
Film film3 = new Film(3, "Москва слезам не верит", "1979", "СССР", "мелодрама, драма, комедия", 150, 2516245);
Film film4 = new Film(4, "Бриллиантовая рука", "1968", "СССР", "комедия, криминал", 94, -1);
Film film5 = new Film(5, "Свадьба в Малиновке", "1967", "СССР", "мюзикл, комедия, военный", 95, -1);
Film film6 = new Film(6, "Экипаж", "1979", "СССР", "боевик, триллер, драма", 135, -1);
Film film7 = new Film(7, "...А зори здесь тихие", "1972", "СССР", "драма, военный, история", 160, -1);

//Создание коллекции обобщенного типа "List<Film>"
List<Film> filmsList = new List<Film>() 
{
    film1,
    film2,
    film3,
    film4,
    film5,
    film6,
    film7
};
//Создание коллекции обобщенного типа "Stack<Film>"
Stack<Film> filmsStack = new Stack<Film>();
filmsStack.Push(film1);
filmsStack.Push(film2);
filmsStack.Push(film3);
filmsStack.Push(film4);
filmsStack.Push(film5);
filmsStack.Push(film6);
filmsStack.Push(film7);
//Создание коллекции обобщенного типа "Queue<Film>"
Queue<Film> filmsQueue = new Queue<Film>();
filmsQueue.Enqueue(film1);
filmsQueue.Enqueue(film2);
filmsQueue.Enqueue(film3);
filmsQueue.Enqueue(film4);
filmsQueue.Enqueue(film5);
filmsQueue.Enqueue(film6);
filmsQueue.Enqueue(film7);
//Создание коллекции обобщенного типа "Dictionary<string,Film>"
Dictionary<string, Film> filmsDictionary = new Dictionary<string, Film>()
{
    ["Love"] = film1,
    ["Ivan"] = film2,
    ["Moscow"] = film3,
    ["Hand"] = film4,
    ["Malinovka"] = film5,
    ["Crew"] = film6,
    ["Zori"] = film7
};

//Демонстрация работы со списком
//Выбрать фильмы, выпущенные раньше 1970 года
Console.WriteLine("\nДемонстрация работы со списком. \nФильмы, выпущенные раньше 1970 года:");
List<Film> filteredFilms = filmsList.Where(f => Convert.ToInt32(f.Year) < 1970).ToList();
//Вывести на экран отфильтрованные фильмы
foreach(var film in filteredFilms)
{
    Console.WriteLine(film);
}

//Демонстрация работы со стеком
//Содержимое стека до его изменения
Console.WriteLine("\nДемонстрация работы со стеком. \nСодержимое стека до его изменения:");
foreach (var film in filmsStack)
{
    Console.WriteLine(film);
}
//Выбрать из стека два элемента и вернуть 1 элемент обратно
Film z1 = filmsStack.Pop();
Film z2 = filmsStack.Pop();
filmsStack.Push(z1);
//Содержимое стека после его изменения
Console.WriteLine("\nСодержимое стека после его изменения:");
foreach (var film in filmsStack)
{
    Console.WriteLine(film);
}


//Демонстрация работы с очередью
//Содержимое очереди до ее изменения
Console.WriteLine("\nДемонстрация работы с очередью. \nСодержимое очереди до ее изменения:");

foreach (var film in filmsQueue)
{
    Console.WriteLine(film);
}
//Выбрать из очереди два элемента и вернуть 1 элемент обратно
Film z3 = filmsQueue.Dequeue();
Film z4 = filmsQueue.Dequeue();
filmsQueue.Enqueue(z3);
//Содержимое очереди после ее изменения
Console.WriteLine("\nСодержимое очереди после ее изменения:");
foreach (var film in filmsQueue)
{
    Console.WriteLine(film);
}


//Демонстрация работы со словарем
//Информация об объекте до изменений
Console.WriteLine("\nДемонстрация работы со словарем. \nИнформация об объекте с ключом \"Love\" до изменений:");
Console.WriteLine(filmsDictionary["Love"]);
//Изменение объекта из словаря с соответствующим ключом
filmsDictionary["Love"].FeesInTheWorld = 50000;
//Информация об объекте после изменений
Console.WriteLine("\nИнформация об объекте с ключом \"Love\" после изменений:");
Console.WriteLine(filmsDictionary["Love"]);

Console.WriteLine("\nЗавершение лабораторной работы №11");
