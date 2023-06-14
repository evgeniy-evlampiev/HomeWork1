// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine()!);

// if (number1 > number2)
// {
//     Console.WriteLine($"max -> {number1}");
// }
// else Console.WriteLine($"max -> {number2}");




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine()!);

// int Max = num1;
// if(Max < num2)
// {
//     Max = num2;
// }
// if(Max < num3)
// {
//     Max = num3;
// }
// Console.WriteLine($"Максимальное число из трех чисел: {Max}");




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if(num % 2 == 0)
{
    Console.WriteLine($"{num} - четное число");
}
else
{
    Console.WriteLine($"{num} - нечетное число");
}