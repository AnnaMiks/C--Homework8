// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] MultipleArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    return resultArray;
}
int[,] a_array = GenereteArray(m, n);
System.Console.WriteLine("Первый массив: ");
WriteArrayToConsole(a_array);
int[,] b_array = GenereteArray(n, m);
System.Console.WriteLine("Второй массив: ");
WriteArrayToConsole(b_array);
System.Console.WriteLine($"Их произведение: ");
WriteArrayToConsole(MultipleArray(a_array, b_array));