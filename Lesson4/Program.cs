// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n -1);
// } 
// System.Console.WriteLine(Factorial(10));



// string[,] table = new string[2,5];
// for (int i = 0; i < 2; i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < 5; j++)
//     {
//         table[i,j] = "+";
//         System.Console.Write(table[i,j]);
//     }
// }

int[,] matrix = new int[5,10];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix[i,j] = new Random().Next(1,10);
       System.Console.Write(matrix[i,j]);
    }
}
