// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter first number for Task_1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number for Task_1");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Max number = ");
    Console.WriteLine(number1);
    Console.Write("Min number = ");
    Console.WriteLine(number2);
}
else if(number1 == number2)
{
Console.Write("Max number = Min number = ");
    Console.WriteLine(number1);
}
else
{
    Console.Write("Max number = ");
    Console.WriteLine(number2);
    Console.Write("Min number = ");
    Console.WriteLine(number1); 
}
// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number for Task_2");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number for Task_2");
int number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number for Task_2");
int number5 = Convert.ToInt32(Console.ReadLine());

if (number3 > number4)
{
    if(number3 > number5)
    {
        Console.Write("Max number = ");
        Console.WriteLine(number3);
    }
   
}
else if(number4 > number5)
{
    Console.Write("Max number = ");
    Console.WriteLine(number4);
}
else
{
    Console.Write("Max number = ");
    Console.WriteLine(number5); 
}

// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter number for Task_3");
int number6 = Convert.ToInt32(Console.ReadLine());
if (number6 % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}