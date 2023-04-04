// Программа преворачивает массив

// int size = new Random().Next(4,8);
// int[] Array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     Array[i] = new Random().Next(0,10);
// }
// System.Console.WriteLine($"[{String.Join(", ", Array)}]");
// System.Console.WriteLine();
// int x = size/2;

// int temp = 0;
// for (int i = 0; i < size/2; i++)
// {
//     temp = Array[i];
//     Array[i] = Array[(size - 1) - i];
//    Array[(size - 1) - i] = temp;
// }
// Console.WriteLine($"[{String.Join(", ", Array)}]");

// Программазадаёт три числа и проверет может ли сущестовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника - каждая сторона треугольника меньше суммы двух других сторон

// int a = new Random().Next(4, 20);
// int b = new Random().Next(4, 20);
// int c = new Random().Next(4, 20);
// System.Console.WriteLine($"Стороны: {a} {b} {c}");

// if (a >= b + c)
// {

//     System.Console.WriteLine("Нет, не может");

// }
// else if (b >= a + c)
// {
//     System.Console.WriteLine("Нет, не может");

// }
// else if (c >= a + b)
// {
//     System.Console.WriteLine("Нет, не может");

// }
// else
// {
//     System.Console.WriteLine("Да, возможно");
// }

// Программа преобразовывает десятичное число в двоичное

// System.Console.WriteLine("Введите дестяичное число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int number = x;
// int count = 0;
// int y = -1;
// while (x != 1)
// {
//     y = x / 2;
//     x = y;
//     count = count + 1;
// }
// count = count + 1;

// int[] array = new int[count];
// for (int i = 0; i < count; i++)
// {
//     array[(count - 1) - i] = number % 2;
//     number = number/2;
// }
// System.Console.WriteLine($"[{String.Join("", array)}]");



// Программа выводит N чисел Фибоначчи
// System.Console.WriteLine("Введите длину ряда для чисел Фибоначчи");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[N];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < N; i++)
// {
//     array[i] = array[i - 1] + array[i - 2];
// }
// System.Console.WriteLine($"[{String.Join(" ", array)}]");


// Программа создает копию массива путём поэлементного копирования

// int length = new Random().Next(6,11);
// int[] array = new int[length];
// for (int i = 0; i < length; i++)
// {
//     array[i] = new Random().Next(1,10);
// }
// System.Console.WriteLine($"[{String.Join(" ", array)}]");
// System.Console.WriteLine();

// int[] copy = new int[length];
// for (int i = 0; i < length; i++)
// {
//     copy[i] = array[i];
// }
// System.Console.WriteLine($"[{String.Join(" ", copy)}]");
