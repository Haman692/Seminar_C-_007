// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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

int colums = AddNumber("Enter the number of columns");
int lines = AddNumber("Enter the number of lines");
int min = AddNumber("Enter the minimum number");
int max = AddNumber("Enter the minimum number");

int [,] matrix = new int[colums, lines];
ArrayWithRundomNumbers(matrix, min, max);
ShowMatrix(matrix);