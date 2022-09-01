﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixRndInt(int row, int col , int min , int max)
{
    int[,] matrix = new int [row,col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i,j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

double[] ArithmMeanColums(int[,] matrix)
{
    double[] avgArray = new double [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        avgArray[i] = Math.Round(sum/matrix.GetLength(1),1);;
    }
    return avgArray;

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
double[] avgarr = ArithmMeanColums(array2D);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(avgarr);
