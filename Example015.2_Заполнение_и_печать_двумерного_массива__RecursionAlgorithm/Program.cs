// Заполнение и печать Двумерного массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //внешний цикл по i - щелкающие строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) //внутрений цикл по j - щелкающие столбцы
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine(); // принудительно соскакиваем на следующую строчку при выводе
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i, j] = new Random().Next(1, 10); // обращаемся к строкам i (идём по внешке) и столбцам j (идём внутри)
        }
    }
}


int[,] matrix = new int [3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);