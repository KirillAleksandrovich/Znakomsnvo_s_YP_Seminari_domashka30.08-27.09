// Задача 6: 
// Напишите программу. 
// Которая на вход принимает число.
// И выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("А кто это тут к нам пожаловал? ");
String username = Console.ReadLine();

Console.WriteLine($"Я тебя ждал {username}!");

Console.WriteLine($"Что ж {username}, давай проверим чётность чисел! {username}, введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
    Console.Write($"Смотри {username}, {num} является чётным числом.");
}
else
{
Console.Write($"Смотри {username}, {num} является нечётным числом.");
}