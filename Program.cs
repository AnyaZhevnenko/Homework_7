// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Console.WriteLine("Создаём массив. \nВведите колличество строк:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Создаём массив. \nВведите колличество столбцов:");
// int columns = int.Parse(Console.ReadLine());
// double [,] GetArray(int rows, int columns)
// {
//     double [,] array = new double[rows, columns];
//     Random arrayRandomValue = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     array[i, j] = arrayRandomValue.NextDouble() * (10 + 10) - 10;
//                 }
//             }
//     return array;
// }
// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write("{0,8}", Math.Round(array[i, j], 1));
//         }
//         Console.WriteLine();
//     }
// }
// double [,] array = GetArray(rows, columns);
// Console.WriteLine("Массив случайных вещественных чисел: \n");
// PrintArray(array);

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// int [,] GetArray(int rows, int columns)
// {
//     int [,] array = new int[rows, columns];
//     Random arrayRandomValue = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     array[i, j] = arrayRandomValue.Next(1, 10);
//                 }
//             }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write("{0,6}", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// int [,] array = GetArray(4, 4);
// void SearchArrayIndex (int userRow, int userColumn)
// {
//     if (userRow <= array.GetLength(0) - 1 && userColumn <= array.GetLength(1) - 1)
//         Console.WriteLine($"Значение элемента в указанной позиции = [{userRow},{userColumn}] = {array[userRow,userColumn]}");
//     else if (userRow > array.GetLength(0) - 1 || userColumn > array.GetLength(1) - 1)
//         Console.WriteLine($"Не существует элемента в указанной позиции = [{userRow},{userColumn}]");
// }
// Console.WriteLine("Введите номер строки массива: ");
// int userRow = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите номер столбца массива: ");
// int userColumn = int.Parse(Console.ReadLine());
// PrintArray(array);
// SearchArrayIndex(userRow, userColumn);

// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите колличество строк массива:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите колличество столбцов массива:");
// int columns = int.Parse(Console.ReadLine());
// int [,] GetArray(int rows, int columns)
// {
//     int [,] array = new int[rows, columns];
//     Random arrayRandomValue = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     array[i, j] = arrayRandomValue.Next(1, 10);
//                 }
//             }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write("{0,6}", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
// void AverageArrayColumns(int[,] array)
// {
//     double result = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             result = result + array[j, i];
//         }
//         Console.WriteLine($"Среднее арифметическое {i + 1} столбца {Math.Round(result / array.GetLength(0), 1)}");
//         result = 0;
//     }
// }
// int [,] array = GetArray(rows, columns);
// PrintArray(array);
// Console.WriteLine();
// AverageArrayColumns(array);