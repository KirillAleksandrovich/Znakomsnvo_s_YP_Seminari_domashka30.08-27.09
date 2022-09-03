// Задача 2: 
// Напишите программу. 
// которая на вход принимает два числа
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("Как тебя зовут? Давай знакомиться: ");
String username = Console.ReadLine();

Console.Write($"{username}, введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"{username}, введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"Оу, смотри, {num1} - больше чем - {num2}");
}
else if (num1 == num2)
{
    Console.Write("А эти числа равны, дружище!");
}
else
{
    Console.Write($"Оу, смотри, {num2} - больше чем - {num1}");
}