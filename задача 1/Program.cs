// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ();

void PrintArray (double [,] matrix)
{
    for (int i =0; i < matrix.GetLongLength (0); i ++)
    {
        for (int j= 0;  j < matrix.GetLongLength (1); j ++)
        {
            Console.Write($"{matrix [i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10}     ");
        }
    Console.WriteLine ();
    }
}

double[,] array = new double[m, n];
PrintArray (array);

