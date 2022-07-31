class Товар
{
    public int КодТовара;
    public string Наименование;
    public double Цена;
    public Товар()
    {
    }
    public Товар(int код, string наимен, double цена)
    {
        this.КодТовара = код;
        this.Наименование = наимен;
        this.Цена = цена;
    }
    public override string ToString()
    {
        return string.Format("Код={0} {1} Цена={2} руб",
        this.КодТовара, this.Наименование, this.Цена);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Товар t1 = new Товар(10, "Кабель телефонный", 2500);
        Товар t2 = new Товар(20, "Уголок пластик", 850);
        Товар t3 = new Товар(30, "Шнур питания", 250);
        Товар t4 = new Товар(40, "Шнур питания", 250);
        //Добавление новых объектов
        Товар t5 = new Товар(50, "Роутер", 5600);
        Товар t6 = new Товар(60, "Клавиатура", 2330);
        Товар t7 = new Товар(70, "Мышь", 1750);
        Товар t8 = new Товар(80, "Ноутбук", 64000);
        System.Collections.Generic.Dictionary<int, Товар> СправочникТоваров = new Dictionary<int, Товар>()
        {
            {10,t1},
            {20,t2},
            {30,t3},
            {40,t4},
            {50,t5},
            {60,t6},
            {70,t7},
            {80,t8}
        };
        foreach (KeyValuePair<int, Товар> x in СправочникТоваров)
        {
            Console.WriteLine("Код= {0} Элемент={1}", x.Key, x.Value);
        }
        int k = 30;
        if (!СправочникТоваров.ContainsKey(k))
            Console.WriteLine("Нет элемента номер {0}", k);
        else
            Console.WriteLine("Есть элемент номер {0}", k);
        foreach (var i in СправочникТоваров.Keys)
            Console.WriteLine("Код {0}", i);
        Console.WriteLine("Код {0}", СправочникТоваров.Keys.ToArray<int>()[1]);
        СправочникТоваров.Remove(20);
        foreach (KeyValuePair<int, Товар> x in СправочникТоваров)
        {
            Console.WriteLine("Код= {0} Элемент={1}", x.Key, x.Value);
        }
        SortedDictionary<int, Товар> СортированныйСловарь =
        new SortedDictionary<int, Товар>()
        {
             {40,t1},
            {10,t2},
            {30,t3},
            {22,t4},
            {50,t5 },
            {100,t6},
            {1,t7},
            {2,t8},
        };
        Console.WriteLine("\n\n\n");
        foreach (KeyValuePair<int, Товар> x in СортированныйСловарь)
        {
            Console.WriteLine("Код= {0} Элемент={1}", x.Key, x.Value);
        }
        System.Console.ReadLine();
    }
}

