
// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int AddNumber(string argument)
{
    System.Console.WriteLine(argument);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void ArrayWithRundomNumbers(int[,] arr, int leftRange, int rightRange)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

}

void ShowMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void ShowsDioganalSum(int [,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }
    System.Console.WriteLine("Diagonal sum = " + sum);    

}

void ShowsObDioganalSum(int [,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, arr.GetLength(0) -1 - i];
    }
    System.Console.WriteLine("ObDiagonal sum = " + sum);    

}

int colums = AddNumber("Enter the number of columns");
int lines = AddNumber("Enter the number of lines");
int min = AddNumber("Enter the minimum number");
int max = AddNumber("Enter the minimum number");
int [,] matrix = new int[colums, lines];
ArrayWithRundomNumbers(matrix, min, max);
ShowMatrix(matrix);
ShowsDioganalSum(matrix);
ShowsObDioganalSum(matrix);