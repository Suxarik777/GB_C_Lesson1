

string[,] table = new string [2, 5]; //[,] означает что массив двумерный - [строкаб столбец]

//ВАЖНЫЙ ПРИКОЛ!!!!! указывается 2 строки человечиским языком! НО индексы от 0!!! а значит будет
//
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4] 
// table[1, 0] ...
// 
// (то есть 2 строки это от 0 и 1, в стоблцы от 0 до 4 по индексам)

//String.Empty - команда пустой строки (вспоминаем) - инициализация строки

table[1, 2] = "слово"; //обращение к нужному элементу Название [индекс строки и индекс столбца]

for (int rows = 0; rows < table.GetLength(0); rows++) //rows - строка //НОВАЯ КОМАНДА! table.GetLength(0) 
{
    for (int columns = 0; columns < table.GetLength(1); columns++) //columns столбцы
    {
        Console.Write($"-{table[rows, columns]}-");
    }
Console.WriteLine(); // принудительно соскакиваем на следующую строчку при выводе
}

Console.WriteLine("========================");


// 
int[,] matrix = new int [3, 4];

for (int i = 0; i < matrix.GetLength(0); i++) //внешний цикл по i - щелкающие строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) //внутрений цикл по j - щелкающие столбцы
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine(); // принудительно соскакиваем на следующую строчку при выводе  
}