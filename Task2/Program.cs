/// Написать программу масштабирования фигуры

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int length= ReadInt("Введите колличество строк: ");
int width= ReadInt("Введите колличество столбцов: ");
int Num= ReadInt("Введите коэффициент: ");

double[,] matrix = new double[length, width];
Console.WriteLine();

Console.WriteLine("Изначальная фигура: ");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        Random r = new Random();
        matrix[i, j] = new Random().Next(100,999);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

double[,] CopyMatrix= new double[length,width];

    Console.Write("Маштабированая матрица: ");
    Console.WriteLine();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
        CopyMatrix[i, j] = matrix[i,j]*Num;
        Console.Write(CopyMatrix[i, j] + "\t");
        }
    Console.WriteLine();
    }
Console.WriteLine();