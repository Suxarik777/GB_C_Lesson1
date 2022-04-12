void FillArray(int[] collection)
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

int[] array = new int[10]; //переменная массива = создай новый массив из 10 элементов (важно понимать он пустой будет)

FillArray(array); //запустили функцию которая заполнила нам массив случайными числами
PrintArray(array); //запустили функцию которая переберая массив по индексу через Console.WriteLine(col[index]) нам всё вывела
