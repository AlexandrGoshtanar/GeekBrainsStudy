// Даны два числа. Показать большее и меньшее число
Console.WriteLine("ЗАДАЧА 2");
int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);
Console.WriteLine("num1 = " + num1);
Console.WriteLine("num2 = " + num2);
if(num1>num2)
{
    Console.WriteLine("max = " + num1);
    Console.WriteLine("min = " + num2);
}
else
{
Console.WriteLine("max = " + num2);
Console.WriteLine("min = " + num1);
}
//Найти максимальное из трёх чисел.
Console.WriteLine("ЗАДАЧА 4");
int number1 = new Random().Next(1, 100);
int number2 = new Random().Next(1, 100);
int number3 = new Random().Next(1, 100);
int max = number1;
Console.WriteLine("number1 = " + number1);
Console.WriteLine("number2 = " + number2);
Console.WriteLine("number3 = " + number3);
if(number2>max) max=number2;
if(number3>max) max=number3;
Console.WriteLine("max= " + max);
//Выяснить является ли число чётным
Console.WriteLine("Задача 6");
Console.WriteLine("Введите число: ");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("numb1 = " + numb1);
numb1= numb1 %2;
if(numb1==0) Console.WriteLine("четное");
else
Console.WriteLine("нечетное");
//Показать чётные числа от 1 до N
Console.WriteLine("Задача 8");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
string[] array = {1,N};
int index = 0;
while(index<N)
{
    array[index] = array[index] %2;
}
if(array[index] == 0)
{

}