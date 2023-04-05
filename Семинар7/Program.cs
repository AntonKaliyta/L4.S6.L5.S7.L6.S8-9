// Программа создает двумерный массив со случайными числами

// System.Console.WriteLine("Введите кол-во строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());


// int [,] array = new int[m,n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);
//         System.Console.Write(array[i,j]);
//     }
// }

// Программа моздает двумерный массив рамера m на n , каждый элемент находится по формуле array[m,m] = m+n

// System.Console.WriteLine("Введите кол-во строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         System.Console.Write(array[i,j]);
//     }
// }

// Программа задает двумерный массив, а затем заменяет элементы у которых оба индексы ченые на квадраты этих элементов

// int[,] array = new int[5, 5];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 5);
//         System.Console.Write(array[i, j]);
//     }
// }

// System.Console.WriteLine();
// System.Console.WriteLine();

// for (int k = 0; k < array.GetLength(0); k++)
// {
//     System.Console.WriteLine();
//     for (int l = 0; l < array.GetLength(1); l++)
//     {
//         if (k % 2 == 0 && l % 2 == 0)
//         {
//             array[k, l] *= array[k, l];
//         }
//         System.Console.Write(array[k,l]);
//     }
// }

// Программа задает двумерных массив и находит сумму элементов, находящихся на главной диагонали


// int[,] array = new int [4,4];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);
//         System.Console.Write(array[i,j]);
//     }
// }
// int l = 0;
// int sum = 0;
// for (int k = 0; k < array.GetLength(0); k++)
// {
//    sum = sum + array[k,l];
//    l++; 
// }
// System.Console.WriteLine();
// System.Console.WriteLine(sum);

