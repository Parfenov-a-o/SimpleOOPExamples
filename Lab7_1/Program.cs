using Lab7_1;
Счетчик x1 = new Счетчик() { Величина = 15 };
Счетчик x2 = new Счетчик() { Величина = -5 };
Console.WriteLine(" {0} \n {1} ", x1, x2);

Счетчик x3 = x1 + x2;

Console.WriteLine(" x3={0}", x3);

if(x1<x2)
{
    Console.WriteLine(" {0} меньше {1} ", x1, x2);
}
else
{
    Console.WriteLine(" {0} не меньше {1} ", x1, x2);
}

int i = (int)x1;

Счетчик x4 = new Счетчик();

x4 = (Счетчик)60;

Console.WriteLine("i={0} \n x4={1}", i, x4);

//Использование добавленных перегруженных операторов
if(x1)
{
    Console.WriteLine("Значение x1 = {0} больше или равно нулю!",x1);
}    
else
{
    Console.WriteLine("Значение x1 = {0} меньше нуля!", x1);
}

if (x2)
{
    Console.WriteLine("Значение x2 = {0} больше или равно нулю!", x2);
}
else
{
    Console.WriteLine("Значение x2 = {0} меньше нуля!", x2);
}

Счетчик x5 = x1 - x2;

Console.WriteLine(" x5={0}", x5);

Счетчик x6 = x1 * x2;

Console.WriteLine(" x6={0}", x6);

Счетчик x7 = x1 / x2;

Console.WriteLine(" x7={0}", x7);

