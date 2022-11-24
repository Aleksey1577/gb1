
// Задача 2 ////////////////////////////////////////////


int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);


// Задача 4 ///////////////////////////////////////////////


int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine(max);


// задача 6 /////////////////////////////////////////////


Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}


// Задача 8 ///////////////////////////////////////////////


Console.Write("Введите число : ");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();