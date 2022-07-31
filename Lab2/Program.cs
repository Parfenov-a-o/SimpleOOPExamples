using Lab2;
using System.IO;
Console.WriteLine("Добро пожаловать в лабораторную работу №2\n");
//Массив из объектов типа "Film"
Film[] films = new Film[3];
//Заполняем первый элемент массива созданным экзепляром класса.
films[0] = new Film();
//Выводим информацию об объекте на экран, с помощью метода PrintInfo()
Console.WriteLine("Вывод информации об объекте с помощью метода PrintInfo():");
films[0].PrintInfo();
films[1] = new Film(1, "Любовь и голуби", "1984", "СССР", "мелодрама, комедия", 107, -1 );
films[2] = new Film(2, "Иван Васильевич меняет профессию", "1973", "СССР", "комедия, фантастика, приключения", 88, -1);
Console.WriteLine("\nВывод информации об объектах с помощью переопределенного метода ToString():");
Console.WriteLine($"{films[1]}\n{films[2]}");
string str = "";
for(int i = 0; i < films.Length; i++)
{
    if(i>0)
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
for(int i = 0; i < readingLinesFromFile.Length; i++)
{
    readingFilmsFromFile[i] = new Film(readingLinesFromFile[i]);
    Console.WriteLine(readingFilmsFromFile[i]);
}
Console.WriteLine("\nМассив объектов успешно загружен из файла!");
Console.WriteLine("\nЗавершение лабораторной работы №2");



