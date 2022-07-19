// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] TwoDimensionalArray(double m, double n, double minValue, double maxValue)
// {
//     Random rnd = new Random();
//     double[,] myArray = new double[3, 4];

//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             myArray[i, j] = rnd.Next(-5, 7) / 2.0;
//     for (int i = 0; i < 5; i++) Console.WriteLine();


//     return myArray;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
// }

// Console.Write("Input m: ");
// double m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// double n = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = TwoDimensionalArray(m, n, -5, 5);
// Show2dArray(newArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

// void FindingArrayValue()
// {
//     Console.Write("Input rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine()) - 1;
//     Console.Write("Input columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine()) - 1;

//     Random random = new Random();
//     int[,] newArray = new int[7, 9];

//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = random.Next(10, 99);
//             Console.Write("{0} ", newArray[i, j]);
//         }
//         Console.WriteLine();
//     }

//     if (rows < 0 | rows > newArray.GetLength(0) - 1 | columns < 0 | columns > newArray.GetLength(1) - 1)
//     {
//         Console.WriteLine("Element does not exist");
//     }
//     else
//     {
//         Console.WriteLine("Element value: {0}", newArray[rows, columns]);
//     }
// }

// FindingArrayValue();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void Average()
// {
//     Console.WriteLine("Input matrix");
//     Console.Write("Input rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     int[] sum = new int[columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);

//         }
//     }
//     Console.WriteLine();

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             Console.Write(matrix[j, i] + " ");
//             sum[j] += matrix[j, i];
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     foreach (double elem in sum)
//     {
//         Console.WriteLine($"Average column:" + elem / columns);
//     }
// }

// Average();

