//Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");
bool X = true;
bool Y = true;
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
Console.WriteLine("Задача 22: Найти расстояние между точками в пространстве 2D/3D");
int x1 = new Random().Next(1,10);
int x2 = new Random().Next(1,10);
int y1= new Random().Next(1,10);
int y2 = new Random().Next(1,10);
int z1 = new Random().Next(1,10);
int z2 = new Random().Next(1,10);
Console.WriteLine($"x1 = {x1}, x2 = {x2}, y1 = {y1}, y2 = {y2}, z1 = {z1}, z2 = {z2} ");
double X1 = Math.Pow((x2-x1),2);
double Y1 = Math.Pow((y2-y1),2);
double Z1 = Math.Pow((z2-z1),2);
double D2 = Math.Sqrt(X1 + Y1);
double D3 = Math.Sqrt(X1 + Y1 + Z1);
Console.WriteLine("Расстояние между двумя точками в пространстве 2D равно " + D2);
Console.WriteLine("Расстояние между двумя точками в пространстве 3D равно " + D3 );
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
