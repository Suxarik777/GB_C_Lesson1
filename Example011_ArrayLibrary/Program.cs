void FillArray(int[] collection) //void это такой тип данных который при функции не возвращает ничего
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}

int IndexOf(int[] collection, int find)// функция в которую приходит в качестве аргумента массив collection и аргумент find
{
    int count = collection.Length; //определяем количество элементов в массиве и заносим в переменую
    int index = 0;
    int position = 0; //создали переменную чтобы сохранять данные ниже

    while (index < count) // то есть при помощи такой конструкции мы идём по длине массива не занося четких цифр
    {
        if(collection[index] == find)
        {
            position = index;
            break;                  //при помощи break мы тормозим поиск на первом найденом элементе и воответсвенно выводим его индекс
        }                           //в противном случае вывелся бы последний индекс элемента который мы ищим
        index++;
    }
    return position;
}


int[] array = new int[10]; //переменная массива = создай новый массив из 10 элементов (важно понимать он пустой будет)

FillArray(array); //запустили функцию которая заполнила нам массив случайными числами
//array[4]= 4; //тут мы искуственно после функции засунунли четвёрки чтобы проверить навернека в 4 и 6 позицию
//array[6]= 4;
PrintArray(array); //запустили функцию которая переберая массив по индексу через Console.WriteLine(col[index]) нам всё вывела
Console.WriteLine();

int pos = IndexOf(array, 4); //делаем переменную в которую кладём результат работы функции (в качестве аргумента передаём)
Console.WriteLine(pos); //показываем что сделала функция в терминал