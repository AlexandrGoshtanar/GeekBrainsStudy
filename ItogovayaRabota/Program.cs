Console.Clear();
// создаем массив
string[] ArrString = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };
Console.Write("Старый Массив: ");
for (int i = 0; i < ArrString.Length; i++)
{
    Console.Write("{1} ", i, ArrString[i]);
}
// Генерируем размер нового массива
int numb1 = new Random().Next(0, 4);
// и сам новый массив
string[] ArrString2 = new string[numb1];
Console.WriteLine();
// выводив в консоль новый массив
Console.Write("Новый массив: ");
for (int i = 0; i < ArrString2.Length; i++)
{
    // генерируем случаное слово из первого массива
    int numb2 = new Random().Next(0, 7);
    Console.Write(ArrString[numb2] + " ");

}

