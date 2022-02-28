void fillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
//Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
/* int m = 10;
int n = 5;
int[,] array = new int[m, n];
fillArray(array);
PrintArray(array); */
//Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.
/* int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
    }
}
PrintArray(array); */
//Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
/* int[,] array = new int[5, 5];
fillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (A == array[i, j]) Console.WriteLine($"Строка:{i + 1},Столбец:{j + 1}");
    }
} */
//Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
/* int[,] array = new int[5, 5];
fillArray(array);
PrintArray(array);
double SredArif = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    SredArif = (array[0, i] + array[1, i] + array[2, i] + array[3, i] + array[4, i]) / array.GetLength(1);
    Console.WriteLine($"среднее арифметическое столбца {i + 1} равно: {SredArif} ");
}


 */