// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.


int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int m = Prompt("Введите количество строк в массиве");
int n = Prompt("Введите количество столбцов в массиве");

int[,] GenereteArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void WriteArrayToConsole(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] SortRows(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = matrix.GetLength(1) - 1; j > i; j--)
                if (matrix[rows, j] > matrix[rows, j - 1])
                {
                    int tmp = matrix[rows, j];
                    matrix[rows, j] = matrix[rows, j - 1];
                    matrix[rows, j - 1] = tmp;
                }
    return matrix;
}

int[,] d_array = GenereteArray(m,n);
System.Console.WriteLine("Изначальный массив: ");
WriteArrayToConsole(d_array);
System.Console.WriteLine("Отсортированный: ");
WriteArrayToConsole(SortRows(d_array));
