// Числа Фибоначчи
// каждое следующее число задаётся предыдущим

//=================
// Фибоначчи
// 1 1 2 3 5 8 13 21 …

// F  = F    +  F
//  n    n-1     n-2
//==================

// F(1) = 1
// F(2) = 1
// F(3) = 2 (F(3) = F (3 - F(1)) + (3 - F(2)))
// F(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci (n - 1) + Fibonacci (n -2);
}

//с помощью for смотрим как будут считатся некоторые числа фибоначи
int fibNumber = 10;
Console.WriteLine($"Смотрим числа фибоначчи от 1 до {fibNumber} в контейнере (типе данных) int (целые числа)");
for(int i = 1; i < fibNumber; i++)
{
    Console.WriteLine(Fibonacci(i));
}

//смотрим теперь что происходит через тип данных double

double Fibonacci_ver_double(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci_ver_double (n - 1) + Fibonacci_ver_double (n -2);
}

Console.WriteLine();
//с помощью for смотрим как будут считатся некоторые числа фибоначи
int fibNumber2 = 50;
Console.WriteLine($"Смотрим числа фибоначчи от 1 до {fibNumber2} в контейнере (типе данных) double ");
for(int i = 1; i < fibNumber2; i++)
{
    Console.WriteLine($"F({i}) = {Fibonacci_ver_double(i)}");
}
Console.WriteLine("Мы видим что где то с 40 числа числа выводятся очень и очень медленно");
// как это исправить и сделать либо рекурсию более шустрой, либо заменить циклами - ответ в семинаре