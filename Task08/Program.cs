// Задача 8: 
// Напишите программу. 
// Которая на вход принимает число (N).
// А на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Добро пожаловать путник! Как твоё имя?  ");
String username = Console.ReadLine();

Console.WriteLine($"Я ждал тебя {username}!");

Console.WriteLine($"Сейчас я разложу твоё число на чётные числа. Как всегда вводи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (num > 1 && count != num)
{
    if (count%2 == 0)
    {
        count = count + 2;
        Console.Write($"{count}, ");
        count = count  ++;
    }
   
}
