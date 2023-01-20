//1. Показать таблицу квадратов чисел от 1 до N
/* 
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int number = 1;
while (number <= n)
{
    Console.WriteLine(number*number);
    number ++;
}
 */

// 2. Найти сумму чисел от 1 до А
/* Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int n = 1;
int Sum = 0;
while (n <= A)
{
    Sum = Sum + n;
    n ++;
}
Console.WriteLine(Sum); */

// 3. Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.Write("Введите число А = ");
int A = int.Parse(Console.ReadLine()!); 
Console.Write("Введите натуральное число В = ");
int B = int.Parse(Console.ReadLine()!); 

int counter = 1; //счетчик
int itog = 1; //результат (произведение поэтому 1)
while (counter <= B)
    { 
    itog = itog * A;
    counter++;
    }
Console.WriteLine(itog);
//

