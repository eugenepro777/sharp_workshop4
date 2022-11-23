// Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

var tmp = GetMultiply(5);
Console.WriteLine(tmp);

int GetMultiply(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
