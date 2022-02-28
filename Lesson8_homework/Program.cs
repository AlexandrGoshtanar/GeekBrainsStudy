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
//Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
/* int[,] array = new int[4, 4];
fillArray(array);
PrintArray(array);
int max = 0;
int temp = 0;
Console.WriteLine();
for (int k = 0; k < 5; k++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] > array[i, j - 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j - 1];
                array[i, j - 1] = temp;
            }

        }
    }
}
PrintArray(array); */
//Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.
/* int[,] array = new int[5, 7];
int min = 0;
int minNumber = 0;
int sum = 0;
fillArray(array);
PrintArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == 0)
        {
            sum = sum + array[i, j];
            min = sum;
        }
        else sum = sum + array[i, j];
    }
    if (sum < min)
    {
        min = sum;
        minNumber = i;
    }
    sum = 0;
}
Console.WriteLine(minNumber); */
//Задача 61: Найти произведение двух матриц.
/* int[,] array1 = new int[4, 2];
int[,] array2 = new int[2, 3];
int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
fillArray(array1);
fillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int m = 0;
int n = 0;
if (array1.GetLength(1) == array2.GetLength(0))
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLongLength(1); j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] = array3[i, j] + (array1[i, k] * array2[k, j]);
            }
        }
    }
}
else Console.WriteLine("Матрицы перемножить нельзя");
PrintArray(array3); */