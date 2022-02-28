//Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
/* Console.WriteLine("сколько чисел ввести?");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите числа");
int Count = 0;
for (int i = 0; i < N; i++)
{
    int A = int.Parse(Console.ReadLine());
    if (A > 0) Count++;
}
Console.WriteLine("Количество чисел больше нуля = " + Count); */
//Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
/* double k1 = 2;
double b1 = 3;
double k2 = 4;
double b2 = 6;
double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine($"({x} , {y})"); */
//Задача 46: Написать программу масштабирования фигуры
/* Console.WriteLine("введите координаты");
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"({array[0]},{array[1]}) ({array[2]},{array[3]}) ({array[4]},{array[5]}) ({array[6]},{array[7]})");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * 2;
}
Console.WriteLine($"({array[0]},{array[1]}) ({array[2]},{array[3]}) ({array[4]},{array[5]}) ({array[6]},{array[7]})"); */