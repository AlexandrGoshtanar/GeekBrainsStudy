//Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
bool X = true;
bool Y = false;
if(X && Y)
     Console.WriteLine("не (1+1) = не 1 * не 1");
else if(X && !Y)
     Console.WriteLine("не (1+0) = не 1 * не 0");
else if(!X && Y)
     Console.WriteLine("не (0+1) = не 0 * не 1");
else if(!X && !Y)
     Console.WriteLine("не (0+0) = не 0 * не 0");

//Задача 20: Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Задача 20: Задать номер четверти, показать диапазоны для возможных координат");
Console.WriteLine("Задайте номер четвери");
int Z = int.Parse(Console.ReadLine());
if(Z ==1) Console.WriteLine("X>0, Y>0");
else if(Z ==2) Console.WriteLine("X>0, Y<0");
else if(Z ==3) Console.WriteLine("X<0, Y<0");
else if(Z ==4) Console.WriteLine("X<0, Y>0");
//Задача 22: Найти расстояние между точками в пространстве 2D/3D

//Задача 24: Найти кубы чисел от 1 до N
Console.WriteLine("Задача 24: Найти кубы чисел от 1 до N");
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
int n = 1;
while(n<=N)
{
    Console.Write(n+ " " + (n*n*n));
    Console.WriteLine();
    n++;
}
