//Задача 10: Показать вторую цифру трёхзначного числа.
int number1(int num1)
{
    int result = num1 / 10;
    result = result % 10;
    return result;
}

Console.WriteLine("Введите трехзначное число: ");

int numb = int.Parse(Console.ReadLine());

Console.WriteLine("вторая цифра трехзначного числа: " + number1(numb));

//Задача 12: Удалить вторую цифру трёхзначного числа.
int number2(int num2)
{
    int result = num2 / 100;
    return result;
}
int number3(int num3)
{
    int result = num3 %10;
    return result;
}
Console.WriteLine("Введите трехзначное число: ");

int numb1 = int.Parse(Console.ReadLine());
Console.Write("Новое число: " + number2(numb1));
Console.WriteLine(number3(numb1));

//Задача 14: Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите число: ");
int numb2 = new Random().Next(1, 100);
Console.WriteLine(numb2);
if(numb2 > 99)
{
numb2 = numb2 % 10;
Console.WriteLine("третье число: " + numb2);
}
else
{
    Console.WriteLine("третьего числа нет");
}

//Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int number5 = new Random().Next(1, 7);
Console.WriteLine("день недели по счету: " + number5);
if(number5 > 5)
{
    Console.WriteLine("Ура, сегодня выходной!");
}
else
{
    Console.WriteLine("Опять работа :(");
}