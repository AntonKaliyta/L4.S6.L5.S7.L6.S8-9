void CreateArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            System.Console.Write(matrix[i, j]);
        }
        System.Console.WriteLine();
    }
}

void DecreaseInStrokes(int[,] matrix)
{
    int count = 0;
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        count = 0;
        while (count < matrix.GetLength(1))
        {

            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    temp = matrix[i, j - 1];
                    matrix[i, j - 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
            count++;
        }
    }
}

void ShowArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
    }
}

void FindMinStrokeSum(int[,] matrix)
{
    int min = 1000;
    int sum = 0;
    int minStroke = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < min)
        {
            min = sum;
            minStroke = i;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Наименьшая сумма элементов у строки с индексом {minStroke}");
}

void MultiplicatoinMatrix(int[,] matrix, int[,] secondmatrix, int[,] resultmatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultmatrix[i, j] = matrix[i, j] * secondmatrix[i, j];
            System.Console.Write($"{resultmatrix[i, j]}" + " ");
        }
    }
}

int[,] array = new int[4, 4];

// Задача 53 Программа упорядочивает по убыванию элементы каждой строки двумерного массива.
// CreateArray(array);
// DecreaseInStrokes(array);
// ShowArray(array);

// Программа находит строку с наименьшей суммой элементов.

// CreateArray(array);
// FindMinStrokeSum(array);

// Программа находит произведение двух матриц.

// int[,] newarray = new int[4, 4];
// int[,] resultarray = new int[4, 4];

// CreateArray(array);
// System.Console.WriteLine();
// CreateArray(newarray);
// System.Console.WriteLine();
// MultiplicatoinMatrix(array, newarray, resultarray);

// Программа создаёт трехмерный массив из неповторяющихся двузначных чисел.

// int[,,] cubeArray = new int[2, 2, 2];
// for (int i = 0; i < cubeArray.GetLength(0); i++)
// {
//     for (int j = 0; j < cubeArray.GetLength(1); j++)
//     {
//         System.Console.WriteLine();
//         for (int k = 0; k < cubeArray.GetLength(2); k++)
//         {
//             cubeArray[i, j, k] = new Random().Next(10, 100);
//             Console.Write(cubeArray[i, j, k]);
//             Console.Write("(");
//             Console.Write(i);
//             Console.Write(",");
//             Console.Write(j);
//             Console.Write(",");
//             Console.Write(k);
//             Console.Write(")");
//             Console.Write(" ");
//         }
//     }
// }

// Программа спирально заполняет массив 4 на 4.

int[,] array62 = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= array62.GetLength(0) * array62.GetLength(1))
{
    array62[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array62.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array62.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array62.GetLength(1) - 1)
        j--;
    else
        i--;
}

ShowArray(array62);