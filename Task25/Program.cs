//Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int count = 1;
int temp = num;

while (count < num1)
{
    num=num*temp;
    count++;
}

Console.WriteLine(num);
