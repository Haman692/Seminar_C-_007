//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


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
            arr[i,j] = i + j;
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

int [,] matrix = new int[colums, lines];
MatrixMplusN(matrix, min, max);
ShowMatrix(matrix);