Console.Clear();
//Console.SetCursorPosition(10, 4); //SetCursorPosition (отступ от левого края - 10 верхнего края -4)
//Console.WriteLine("+");   // в консоле строки и символы считают с 0 (не с единицы)

//int xa = 1; // 1 точка - отступ от левого края идём по оси X - 1 строка
//int ya = 1; // 1 точка отступ сверху - ось Y - 1 строка
//int xb = 1;
//int yb = 30;

//при записи точек по осям такой вид записи просто более читаем
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
// в итоге этим блоком команд мы нарисовали в терминале 3 точки равнобедренного треугольник

int x = xa, y = xb; //в точку x и точку y кладут числа , просто для определённости на данном этапе

int count = 0;

while (count < 10);
{
    int what = new Random().Next(0, 3); // напоминалка что полуинтервал! найдёт 0 1 2... 
                            //три числа 0 1 2 мы взяли как выбор случайных 3 точек вершины треугольника
    if(what == 0)
    {
        x = (x + xa) / 2; //кладём x в середину отрезка
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2; 
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2; 
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;

}