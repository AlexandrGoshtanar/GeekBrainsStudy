//Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
/* Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"{M},{N}");
int sum = 0;
for (int i = M; i <= N; i++)
{
    sum = sum + i;
}
Console.WriteLine("Сумма равна " + sum); */
//Показать натуральные числа от N до 1, N задано.
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
int n = 0;
for (int i = 0; i < N; i++)
{
    n = N - i;
    if (n == 1) Console.Write(n);
    else Console.Write(n + ",");
}