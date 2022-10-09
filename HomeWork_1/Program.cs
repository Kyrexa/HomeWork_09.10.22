// Написать программу которая на вход принимает 5 число и проверяет, является ли оно палиндрамом.
Console.Clear();
Console.WriteLine("Напишите число: ");
string n = Console.ReadLine();
int len = n.Length;
if ( len == 5)
{
    if(n[0] == n[4] && n [1] == n[3])
    {
        Console.WriteLine($"{n} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{n} - Не палиндром"); 
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {n} - Не пятизначное число"); 
}