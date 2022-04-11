int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a; //определяем переменную max в которую кладём значение первой гири

if (a > max) max = a; // тупо пеебираем по очереди переменные и оставляем максимальное значение в max
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);