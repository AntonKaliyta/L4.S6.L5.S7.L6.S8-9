// Программа с помощью рекурсии выводит все числа от 1 до N

// void f63(int n)
// {
//     if (n >= 1)
//     {
//         f63(n - 1);
//         Console.Write(n + " ");
//     }
// }


// System.Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// f63(N);


// Прогрмма с помощью рексурсии выводит все числа от M до N

// void f65(int n, int m)
// {
//     if (n > m)
//     {
//         f65(n - 1, m);
//         System.Console.Write(n + " ");
//     }
//     else
//     {
//         System.Console.Write(m + " ");
//     }
// }


// System.Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
// f65(N,M);

//Программа с помощью рекурсии выводит сумму цифр принимаемого числа.


// int F67(int x)
// {
//     if (x < 10) return x;
//     else return x % 10  + F67(x/10);
// }

// System.Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(F67(X));



// Программа с помощью рекурсии возводит число А в степень В.

// int F69(int A, int B)
// {
//     if (B == 1) return A;
//     else return A * F69(A, B -1);
// }

// System.Console.WriteLine("Введите число А ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(F69(a,b));