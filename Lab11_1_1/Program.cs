using Lab11_1_1;

class Program
{
    static System.Collections.IEnumerable МассивСлучайныхЦелыхЧисел(int
   n)
    {
        System.Random rnd = new Random();
        for (int i = 0; i < n; i++)
            yield return rnd.Next(1000);
    }
    static System.Collections.Generic.IEnumerable<Книга> НаборКниг()
    {
        yield return new Книга("Схемотехника");
        yield return new Книга("Предпроектный анализ");
        yield return new Книга("Проектирование ИС");
        yield return new Книга("Алгоритмизация");
        yield return new Книга("Программирование");
        yield return new Книга("Базы данных");
        yield return new Книга("Банки данных");
    }

    //Объединение двух методов в один
    static System.Collections.IEnumerable Набор(int n)
    {
        switch(n)
        {
            case 1:
                yield return new Книга("Схемотехника");
                yield return new Книга("Предпроектный анализ");
                yield return new Книга("Проектирование ИС");
                yield return new Книга("Алгоритмизация");
                yield return new Книга("Программирование");
                yield return new Книга("Базы данных");
                yield return new Книга("Банки данных");
                yield break;
            case 2:
                yield return new CD("CD Схемотехника");
                yield return new CD("CD Предпроектный анализ");
                yield return new CD("CD Проектирование ИС");
                yield return new Книга("Алгоритмизация");
                yield return new Книга("Программирование");
                yield return new CD("CD Базы данных");
                yield return new Книга("Банки данных");
                yield break;
        }

        
    }
    static void Main(string[] args)
    {
        КоллекцияКниг коллекция1 = new КоллекцияКниг();
        foreach (Книга x in коллекция1)
        {
            Console.WriteLine(x);
        }
        for (int i = 0; i < коллекция1.Количество; i++)
        {
            Console.WriteLine(" i= {0} {1}", i, коллекция1[i]);

        }
        var коллекция2 = НаборКниг();
        foreach (Книга x in коллекция2)
        {
            Console.WriteLine(x);
        }
        System.Console.WriteLine("*****************************");
        var коллекция3 = Набор(1);
        foreach (Книга x in коллекция3)
        {
            Console.WriteLine(x);
        }
        System.Console.WriteLine("************Коллекция из объектов разного типа *****************");
       
        var коллекция4 = Набор(2);
        foreach (var x in коллекция4)
        {
            //Использование шаблонов и выражения switch
            switch(x)
            {
                case Книга:
                    Console.Write("Книга {0}", x);
                    Console.WriteLine(" еще раз название " + ((Книга)x).Название);
                    break;
                case CD:
                    ((CD)x).Объем = 2400;
                    Console.WriteLine(" CD {0}", x);
                    break;
                default:
                    Console.WriteLine(" {0} {1}", x.GetType().ToString(), x);
                    break;
            }

        }

        var a = МассивСлучайныхЦелыхЧисел(20);

        foreach (int x in a)
            System.Console.WriteLine(x);
        System.Collections.IEnumerator tt = a.GetEnumerator();
        while (tt.MoveNext())
        {
            if (tt is int)
                System.Console.WriteLine(tt.Current);
            else
                System.Console.WriteLine(" {0} {1} ", tt.GetType(),
               tt.Current);
            int s = (int)tt.Current;
            System.Console.WriteLine(s);

        }
        System.Console.ReadLine();
    }
}
