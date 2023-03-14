// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");


int Sum(int num)
{
    int result = 0;
    for (int i = 0; i < num; i++)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}