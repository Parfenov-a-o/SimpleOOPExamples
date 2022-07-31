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
        Товар t4 = new Товар(40, "Блок питания", 3250);
        //Добавление новых объектов
        Товар t5 = new Товар(50, "Роутер", 5600);
        Товар t6 = new Товар(60, "Клавиатура", 2330);
        Товар t7 = new Товар(70, "Мышь", 1750);
        Товар t8 = new Товар(80, "Ноутбук", 64000);

        Console.WriteLine("Добавление объектов в \"очередь\".");
        System.Collections.Generic.Queue<Товар> Очередь =
        new Queue<Товар>();
        Очередь.Enqueue(t7);
        Очередь.Enqueue(t8);
        Очередь.Enqueue(t1);
        Очередь.Enqueue(t2);
        Очередь.Enqueue(t3);
        Очередь.Enqueue(t4);
        Очередь.Enqueue(t5);
        Очередь.Enqueue(t6);

        Console.WriteLine("Объекты в \"очереди\":");
        foreach (Товар x in Очередь)
        {
            Console.WriteLine(" {0} ", x);
        }
        Console.WriteLine("\nИзвлечение объекта из \"очереди\".");
        Console.WriteLine("Отображение объекта из \"очереди\".");
        Товар z1 = Очередь.Dequeue();
        //Демонстрация вызова метода "Dequeue()"
        Товар z2 = Очередь.Peek();
        Console.WriteLine("Объекты в \"очереди\":");
        foreach (Товар x in Очередь)
        {
            Console.WriteLine(" {0} ", x);
        }

        System.Console.ReadLine();
    }
}

