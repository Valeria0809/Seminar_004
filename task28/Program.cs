// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


// int ReadInt(string text)
// {
//   System.Console.Write(text);
//   return Convert.ToInt32(Console.ReadLine());
// }

// int Factorial(int N)
// {
//     int factorial = 1;

//     for(int i = 1; i <= N; i ++)
//     {
//         factorial = factorial * i;
//     }
//     return factorial;
// }
// int number = ReadInt("Введите число ");
// System.Console.WriteLine(Factorial(number));

// Функция Main----------------------------------------------------------

void Main()
{
    int number = ReadInt("Insert number: ");
    System.Console.WriteLine(Factorial(number));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int N)
{
    int factorial = 1;

    for (int i = 1; i <= N; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

Main();

//Рекурсивная функция--------------------------------------------------------

// int ReadInt(string text)
// {
//   System.Console.Write(text);
//   return Convert.ToInt32(Console.ReadLine());
// }

// int CountFact(int number)
// {
//   if (number == 1)
//     return 1; 
//   return number * CountFact(number - 1); 
// }

// int number = ReadInt("Insert number: ");
// System.Console.WriteLine(CountFact(number));