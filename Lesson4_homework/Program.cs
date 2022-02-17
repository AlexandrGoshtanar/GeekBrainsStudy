//Задача 26: Возведите число А в натуральную степень B, используя цикл.
/* Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());
for (int i = 1; i < 10; i++)
{
    double C = Math.Pow(A,B);
    Console.Write(C + " ");
    A++;
} */
//Задача 28: Подсчитайте сумму цифр в числе.
/* int A = new Random().Next(1,500);
Console.WriteLine("A = "+  A);
int x = 0;
for (int i = 0; i < 10000; i++)
{
    x = x + (A % 10);
    A = A/10;
}
Console.WriteLine(x); */
//Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
/* int[] arr = new int[100];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1,10);
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write(Math.Pow(arr[i],3) + " ");
    }
} */

//Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,2);
    Console.Write(arr[i] + " ");
}