using Lab11_1_2_List;

class Program
{
    static void печать_списка(List<Товар> p)
    {
        foreach (Товар x in p)
        {
            Console.WriteLine("\n{0}", x);
        }
    }
    static void Main(string[] args)
    {
        List<Товар> товар = new List<Товар>() {new Товар(){ Код =1, Название ="Товар1", ОписаниеПолное="Описание", Цена =10000 },
                             new Товар(){ Код =2, Название="Товар2", ОписаниеПолное
                            ="Описание2", Цена =12000 } };
        товар.Add(new Товар()
        {
            Код = 3,
            Название = "Подставка для проектора",
            ОписаниеПолное = "Описание подставки",
            Цена = 4500
        }
        );
        //Добавление нового товара "Проектор"
        товар.Add(new Товар()
        {
            Код = 4,
            Название = "Проектор",
            ОписаниеПолное = "Описание проектора",
            Цена = 25000
        }
        );
        Console.WriteLine("Кол-во={0}", товар.Count);
        foreach (Товар x in товар)
        {
            Console.WriteLine("\n{0}", x);
        }

        //Добавление поиска товаров, стоимостью больше 5000 рублей.
        Console.WriteLine("\nТовары стоимостью больше 5000 рублей:");
        List<Товар> отфильтрованныеТовары = товар.Where(p => p.Цена > 5000).ToList();
        печать_списка(отфильтрованныеТовары);
        

        Console.Write(" Код товара = ");
        string s = Console.ReadLine();
        int n1 = 0;
        int.TryParse(s, out n1);
        Товар z = товар.Find(x => x.Код == n1);
        if (z == null)
        {
            Console.WriteLine("Товара с кодом= {0} нет", n1);
            return;
        }
        else Console.WriteLine(z);
        товар.Remove(z);
        Console.WriteLine("\n\n\n Список товаров после удаления\n");
        печать_списка(товар);
        товар.ForEach(t => {
            Console.Write(" Печать из лямбды");
            Console.WriteLine(" \n {0}", t);
        });

        System.Console.ReadLine();
    }
}

