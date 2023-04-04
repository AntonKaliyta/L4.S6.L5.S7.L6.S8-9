// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int M = new Random().Next(3,7);
// int[] array = new int[M];
// for (int i = 0; i < M; i++)
// {
//     System.Console.WriteLine("Введите число :");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine($"[{String.Join(", ", array)}]");

// int count = 0;
// for (int i = 0; i < M; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями k1 * x + b1 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
System.Console.WriteLine("Введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);


double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

System.Console.WriteLine($"{y1}, {y2}");

