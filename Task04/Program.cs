// Задача 4: Напишите программу. 
// Которая принимает на вход три числа. 
// И выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Привет! Как тебя зовут? ");
String username = Console.ReadLine();
Console.Write($"{username}, введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Теперь, введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"Отлично и ещё введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"Смотри {username}, {max} получается больше всех других чисел :)");
Console.WriteLine($"Как говорила моя бабушка: Ученье свет! А не ученье, как свет так на работу.");

