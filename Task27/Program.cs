//Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
int temp = 0;

while(num >0)
{
    temp = num % 10;
    num /= 10;
    count += temp;
}
Console.Write(count);
