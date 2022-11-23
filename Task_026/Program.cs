// Задача 26: Напишите программу, которая принимает
//  на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetLength(num1));

int GetLength(int num)
{
    int length = 0;
    while (num > 0)
    {
        length++;
        num /= 10; // num = num / 10
    }
    return length;
}