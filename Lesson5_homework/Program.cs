// Задача 34: Написать программу для замены элементов массива на противоположные.
/* void fillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 10);
        Console.Write(num[i] + " ");
    }
}
int[] array = new int[10];
fillArray(array);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
} */
// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
/* void fillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] num1)
{
    for (int i = 0; i < num1.Length; i++)
    {
        Console.Write(num1[i] + " ");
    }
    Console.WriteLine();
}
int[] array = new int[10];
fillArray(array);
PrintArray(array);
int count = 0;
int count1 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count++;
    else count1++;
}
Console.WriteLine($"Четных чисел - {count}, Нечетных чисел - {count1} "); */
// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
/* void fillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 50);
    }
}
void PrintArray(int[] num1)
{
    for (int i = 0; i < num1.Length; i++)
    {
        Console.Write(num1[i] + " ");
    }
    Console.WriteLine();
}
int[] array = new int[20];
fillArray(array);
int summ = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    summ = summ + array[i];
}
PrintArray(array);
Console.WriteLine("сумма чисел,стоящих на нечетной позиции равна " + summ); */
// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
/* void fillArray(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 10) + new Random().NextDouble();
    }
}
void PrintArray(double[] num1)
{
    for (int i = 0; i < num1.Length; i++)
    {
        Console.Write(num1[i] + " ");
    }
    Console.WriteLine();
}
double[] array = new double[5];
fillArray(array);
PrintArray(array);
double max = array[1];
double min = 0;
for (int i = 1; i <array.Length; i++)
{
    if(array[i]>max) max = array[i];
    else min = array[i];
}
Console.WriteLine(max - min); */