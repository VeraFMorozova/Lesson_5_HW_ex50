// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta; 
    Console.Write(data);
    Console.ResetColor();
}

int[,] get2DIntArray(int colLength, int rowLength, int start, int end)
{
   int[,] array = new int[colLength, rowLength];
   for (int i = 0; i < colLength; i++)
   {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, (end+1));
        }
   }
   return array; 
}

void print2DArray(int[,] array)
{
    Console.Write( "\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int number_n = getUserData("Введите количество строк");
int number_m = getUserData("Введите количество столбцов");
int[,] array = get2DIntArray(number_n, number_m, -10, 10);
print2DArray(array);
int number_a = getUserData("Введите номер строки");
int number_b = getUserData("Введите номер столбца");
if(number_a<=array.GetLength(0) && number_b<= array.GetLength(1))
{
    Console.Write($"{array[number_a,number_b]}");
}
else
{
    Console.Write("Такого числа в массиве нет");
}