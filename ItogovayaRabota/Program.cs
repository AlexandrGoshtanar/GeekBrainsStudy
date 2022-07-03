string[] ArrString = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };
int numb1 = new Random().Next(0, 4);
for (int i = 0; i < ArrString.Length; i++)
{
    Console.Write("{1} ", i, ArrString[i]);
}
string[] ArrString2 = new string[numb1];
Console.WriteLine();
for (int i = 0; i < ArrString2.Length; i++)
{
    int numb2 = new Random().Next(0, 7);
    Console.Write(ArrString[numb2] + " ");

}

