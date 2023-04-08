// Программа меняет первую и последунюю строку массива

//     int strokeLength = new Random().Next(3, 6);
//     int colomnLength = new Random().Next(3, 6);
//     int[,] array = new int[strokeLength, colomnLength];

//     for (int i = 0; i < strokeLength; i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < colomnLength; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write(array[i,j]);
//         }
//     }


// int temp = 0;
// for (int k = 0; k < colomnLength; k++)
// {
//     temp = array[0,k];
//     array[0,k] = array[strokeLength-1,k];
//     array[strokeLength-1,k] = temp;
// } 
// System.Console.WriteLine();


// for (int r = 0; r < strokeLength; r++)
//     {
//         Console.WriteLine();
//         for (int t = 0; t < colomnLength; t++)
//         {
//             Console.Write(array[r,t]);
//         }
//     }


// Программа меняет строки на солбцы.

//     int strokes = new Random().Next(3, 6);
//     int colomns = new Random().Next(3, 6);
//     int[,] array = new int[strokes, colomns];
//     int[,] newarray = new int[strokes, colomns];

//     for (int i = 0; i < strokes; i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < colomns; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write(array[i,j]);

//         }
//     }
// System.Console.WriteLine();

// if (strokes == colomns)
// {
//     for (int k = 0; k < colomns; k++)
// {
//     System.Console.WriteLine();
//     for (int l = 0; l < strokes; l++)
//     {
//         newarray[k,l] = array[l,k];
//         System.Console.Write(newarray[k,l]);
//     }
// }
// }
// else
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("Массив несмметричен");
// }


// Программа выводит частотный словарь элементов массива

// int count1 = 0;
// int count2 = 0;
// int count3 = 0;
// int count4 = 0;
// int count5 = 0;
// int count6 = 0;
// int count7 = 0;
// int count8 = 0;
// int count9 = 0;

// int[,] array = new int[3,3];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);
//         System.Console.Write(array[i,j]);
//         if (array[i,j] == 1)
//         {
//             count1++;
//         }
//         else if (array[i,j] == 2)
//         {
//             count2++;
//         }
//         else if (array[i,j] == 3)
//         {
//             count3++;
//         }
//         else if (array[i,j] == 4)
//         {
//             count4++;
//         }
//         else if (array[i,j] == 5)
//         {
//             count5++;
//         }
//         else if (array[i,j] == 6)
//         {
//             count6++;
//         }
//         else if (array[i,j] == 7)
//         {
//             count7++;
//         }
//         else if (array[i,j] == 8)
//         {
//             count8++;
//         }
//         else 
//         {
//             count9++;
//         }
//     }
// }
// System.Console.WriteLine();
// if (count1>0)
// {
//     System.Console.WriteLine($"1 встречается {count1} раз/а");
// }
// if (count2>0)
// {
//     System.Console.WriteLine($"2 встречается {count2} раз/а");
// }
// if (count3>0)
// {
//     System.Console.WriteLine($"3 встречается {count3} раз/а");
// }
// if (count4>0)
// {
//     System.Console.WriteLine($"4 встречается {count4} раз/а");
// }
// if (count5>0)
// {
//     System.Console.WriteLine($"5 встречается {count5} раз/а");
// }
// if (count6>0)
// {
//     System.Console.WriteLine($"6 встречается {count6} раз/а");
// }
// if (count7>0)
// {
//     System.Console.WriteLine($"7 встречается {count7} раз/а");
// }
// if (count8>0)
// {
//     System.Console.WriteLine($"8 встречается {count8} раз/а");
// }
// if (count9>0)
// {
//     System.Console.WriteLine($"9 встречается {count9} раз/а");
// }

// Программа удаляет строку и столбец на пересечении которых находится наименьший элемент массива(если таких несколько, то первый)

// int[,] array = new int[4, 4];
// int min = 10;
// int strokeOfMin = 0;
// int colomnOfMin = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//         if (array[i, j] < min)
//         {
//             min = array[i, j];
//             strokeOfMin = i;
//             colomnOfMin = j;
//         }
//         System.Console.Write(array[i, j]);
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine($"Наименьший элемент равен {min}");

// for (int k = 0; k  < array.GetLength(0); k++)
// {
//     System.Console.WriteLine();
//     for (int l = 0; l < array.GetLength(1); l++)
//     {
//         if (k != strokeOfMin && l != colomnOfMin)
//         {
//             System.Console.Write(array[k,l]);
//         }
//     }
// }



