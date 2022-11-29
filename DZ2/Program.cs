// Задача 10: Напишите программу, которая принимает на вход 
//            трёхзначное число и на выходе показывает вторую цифру 
//            этого числа.

// Вариант 1
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10 % 10;
Console.WriteLine(a);

// Вариант 2
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine(stringNumber[1]);



// Задача 13: Напишите программу, которая выводит третью 
//            цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Enter an integer number");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number > 99)
{
    k = number;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
    Console.WriteLine($"The third number from the left is {d}");
}
else
{
    Console.WriteLine($"The number has fewer than 3 digits, ssory.");
}



// Задача 15: Напишите программу, которая принимает на вход цифру, 
//     обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите число ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
DayOffCheck(dayNumber);


void DayOffCheck(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Выходной");
    }
    else if (dayNumber > 0 && dayNumber < 6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Ошибка, введите число от 1 до 7");
    }
}