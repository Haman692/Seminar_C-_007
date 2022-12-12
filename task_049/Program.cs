// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int AddNumber(string argument)
{
    System.Console.WriteLine(argument);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void MatrixMplusN(int[,] arr, int leftRange, int rightRange)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = arr[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

}

void ShowMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i%2 == 0&& j%2 == 0)
                System.Console.Write(arr[i, j] * arr[i, j] + " ");
            else
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
MatrixMplusN(matrix, min, max);
ShowMatrix(matrix);