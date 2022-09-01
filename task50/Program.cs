// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void CheckPositiionMatrix(int rowPosition,int columPosition, int[,] array)
{
    try
    {
        Console.WriteLine($"{rowPosition}, {columPosition} -> {array[rowPosition-1,columPosition-1]}");
    }
    catch
    {
        Console.WriteLine($"{rowPosition}, {columPosition} -> такого элемента в массиве нет");
    }
}

int RowNumber()
{
    Console.Write("Введите номер строки: ");
    int rowPos = int.Parse(Console.ReadLine());
    return rowPos;
}

int ColNumber()
{
    Console.Write("Введите номер столбца: ");
    int colPos = int.Parse(Console.ReadLine());
    return colPos;
}

Console.WriteLine("Введите позиции элемента: ");
int rowPos = RowNumber();
int colPos = ColNumber();
int [,] array2D = CreateMatrixRndInt(3,4,-9,9);
PrintMatrix(array2D);
CheckPositiionMatrix(rowPos,colPos,array2D);


