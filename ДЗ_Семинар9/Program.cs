// Программа с помощью рекурсии выводит все натуральные числа от N до 1.

// void OneStepDecrease(int n, int m)
// {
//     if (n == m)
//     {
//         Console.Write(n + " ");
//     }
//     else
//     {
//         OneStepDecrease(n, m + 1);
//         System.Console.Write(m + " ");
//     }
// }

// System.Console.WriteLine("Введите N");
// int num = Convert.ToInt32(Console.ReadLine());
// int min = 1;
// OneStepDecrease(num, min);


// Программа находит сумму натуральных элементов от M до N

// int Sum(int m, int n)
// {
//     if (m == n) return n;
//     else return n + Sum(m, n - 1);
// }

// System.Console.WriteLine("Введите M");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите N");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Sum(min, num)); 

// Программа вычисляет функцию Аккермана с помощью рекурсии

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

System.Console.WriteLine("Введите M");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Akkerman(min,num));