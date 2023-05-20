// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int CountNumbers(int number)
{
  int sum = 0;
  while (number != 0)
  {
    number /= 10;
    sum += 1;
  }
  return sum;
}


int number = ReadInt("Введите число ");

System.Console.WriteLine(CountNumbers(number));