// Задача 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом. 
// Полиндром



Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a / 10000) == (a % 10))
{
    a = (a / 10) % 1000;
    if ((a / 100) == (a % 10))
        System.Console.WriteLine($"Число {a} - полиндром");
    else
    {
        System.Console.WriteLine("Не Полиндром");
    }
}
else
{
    System.Console.WriteLine($"Не Полиндром");
}


// 2 Решение

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if ((num / 10000) == (num % 10))
{
    num = (num / 10) % 1000;
}
if((num / 100) == (num % 10))
{
Console.WriteLine("Полиндром");
}
else
{
   Console.WriteLine("НЕ Полиндром"); 
}

//  Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит 
//расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты А");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты B");
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());   
int y3 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1-y1),2) + Math.Pow((x2-y2),2)+ Math.Pow((x3-y3),2));

Console.WriteLine($"{Math.Round(result,2)}");






// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Ведите число");
int N = Convert.ToInt32(Console.ReadLine());

for ( int i = 1 ; i <= N; i++) 
{
int result = i*i*i;
Console.WriteLine($"{result} ");
}