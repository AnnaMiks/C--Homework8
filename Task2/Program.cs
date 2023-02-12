// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int FindMinSumRow(int[,] matrix)
{
    int row = 0;
    int minsum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
        System.Console.WriteLine($"Сумма элементов {i + 1} строки = {sum}");
    }
    return row + 1;

}

int[,] d_array = GenereteArray(m, n);
System.Console.WriteLine("Изначальный массив: ");
WriteArrayToConsole(d_array);
System.Console.WriteLine($"Строка с минимальной суммой - {FindMinSumRow(d_array)} ");