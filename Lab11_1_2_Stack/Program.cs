class Program
{
    static void Main(string[] args)
    {
        System.Collections.Generic.List<string> СписокСтрок =
        new List<string>() { "Красный", "Желтый", "Зеленый" };
        foreach (string t in СписокСтрок)
        {
            System.Console.WriteLine(" {0} ", t);
        }
        СписокСтрок.Add("Синий");
        СписокСтрок.ForEach(x => System.Console.WriteLine(" x= {0}", x));
        System.Collections.Generic.Stack<Товар> СтекТоваров =
        new Stack<Товар>();
        Товар t1 = new Товар(10, "Кабель телефонный", 2500);
        Товар t2 = new Товар(20, "Уголок пластик", 850);
        Товар t3 = new Товар(50, "Роутер", 5600);
        Товар t4 = new Товар(60, "Клавиатура", 2330);
        Товар t5 = new Товар(70, "Мышь", 1750);
        Товар t6 = new Товар(80, "Ноутбук", 64000);
        СтекТоваров.Push(t1);
        СтекТоваров.Push(t2);
        СтекТоваров.Push(new Товар(30, "Шнур питания", 150));
        СтекТоваров.Push(t3);
        СтекТоваров.Push(t4);
        СтекТоваров.Push(t5);
        СтекТоваров.Push(t6);
        Console.WriteLine(" Количество товаров ={0}", СтекТоваров.Count
       );
        foreach (Товар x in СтекТоваров)
        {
            Console.WriteLine(" Товар ={0}", x);
        }
        Товар t7 = СтекТоваров.Pop();
        // Товар t3 = СтекТоваров.Peek();
        Console.WriteLine(" t7 ={0}", t7);
        Console.WriteLine(" Количество товаров ={0}",
       СтекТоваров.Count);
        foreach (Товар x in СтекТоваров)
        {
            Console.WriteLine(" Товар ={0}", x);
        }
        // t3 = СтекТоваров.Peek();
        t7 = СтекТоваров.Pop();
        Console.WriteLine(" t7 ={0}", t7);
        Console.WriteLine(" Количество товаров ={0}",
       СтекТоваров.Count);
        foreach (Товар x in СтекТоваров)
        {
            Console.WriteLine(" Товар ={0}", x);
        }
        t7 = СтекТоваров.Pop();
        Console.WriteLine(" t7 ={0}", t7);
        Console.WriteLine(" Количество товаров ={0}",
       СтекТоваров.Count);
        foreach (Товар x in СтекТоваров)
        {
            Console.WriteLine(" Товар ={0}", x);
        }
        if (СтекТоваров.Count == 0)
        {
            Console.WriteLine("Стек пуст ");
            return;
        }
        Console.WriteLine("peek t7 ={0}", t7);
        t7 = СтекТоваров.Pop();
        Console.WriteLine("pop t7 ={0}", t7);
        Console.WriteLine(" Количество товаров ={0}",
       СтекТоваров.Count);
        foreach (Товар x in СтекТоваров)
        {
            Console.WriteLine(" Товар ={0}", x);
        }
        System.Console.ReadLine();
    }
}

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


