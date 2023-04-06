// Программа задаёт двумерный массив заполненый случайнми вещественными числами.

// System.Console.WriteLine("Введите кол-во строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = Convert.ToDouble(new Random().Next(-90, 90)) / 10;
//         System.Console.Write(array[i, j] + " ");
//     }
// }


// Программа принимает на вход позиции элемента в двумерном массиве и возвращает значение этого элемента

// int[,] array = new int[5,5];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);
//         System.Console.Write(array[i,j] + " ");
//     }
// }


// System.Console.WriteLine();
// System.Console.WriteLine("Введите номер строки элемента");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите номер столбца элемента");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x < 5 && y < 5)
// {
//     System.Console.WriteLine(array[x-1,y-1]);
// }
// else
// {
//     System.Console.WriteLine("такого элемента в массиве нет ");
// }

// Программа задаёт двумерный массив из целых чисел и находит среднее арифметическое в каждом столбце

int x = new Random().Next(3, 5);
int y = new Random().Next(3, 5);
int[,] array = new int[x, y];

for (int i = 0; i < array.GetLength(0); i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 9);
        System.Console.Write(array[i, j] + " ");
    }
}

System.Console.WriteLine();
double[] sum = new double[array.GetLength(1)];
int tempsum = 0;
for (int k = 0; k < array.GetLength(1); k++)
{
    tempsum = 0;
    for (int l = 0; l < array.GetLength(0); l++)
    {
        tempsum += array[l, k];
    }
    sum[k] = tempsum;
}
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(" ", sum)}]");

for (int m = 0; m < sum.Length; m++)
{
    sum[m] = sum[m] / Convert.ToDouble(array.GetLength(0));
}
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(" ", sum)}]");
