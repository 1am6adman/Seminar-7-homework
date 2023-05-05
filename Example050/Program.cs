// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
// Заполнение массива случайными числами
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
// Функция вывода массива 
void PrintArray(int[,] array)
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

int rows = ReadInt("Введите индекс строки от (0 до 5): ");
int colums = ReadInt("Введите индекс столбца от (0 до 8): ");
int[,] numbers = new int[6, 9];
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine($"значение элемента с адресом строки {rows} столбца {colums} цифра {numbers[rows, colums]}");
else Console.WriteLine($"элемента с адресом строки {rows} столбца {colums} в данном массиве не существует");
