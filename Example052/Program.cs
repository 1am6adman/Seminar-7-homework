// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
// Заполнение двумерного массива случайными целыми числами
void FillArrayX(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
//  Функция вывода двумерного массива
void PrintArrayX(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Функция вывода массива
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];
FillArrayX(numbers);
PrintArrayX(numbers);

double[] avgNumbers = new double[numbers.GetLength(0)];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        result += numbers[i, j];
    }
    avgNumbers[i] = result / numbers.GetLength(1);
}
PrintArray(avgNumbers);
