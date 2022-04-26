// Алгоритм сортировки методом выбора
// или Алгоритм сортировки методом min и Max
// или выбором максимального или выбором минимального

// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)    // Функция вывода массива
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{


    for (int i = 0; i < array.Length - 1; i++) //i < array.Length - 1, потому что есть цикл внутри, где мы чтобы
    {                           // не начинать с первого индекса массива прибавляем 1
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) //int j = i + 1 - потому что мы первый элемент отсортировали, начинаем со второго
        {
            if (array[j] < array[minPosition]) //если текущий элемент в массиве меньше предсохранёного элемента в массиве
            {
                minPosition = j;            // то мы в переменной minPosition - сохраняем индекс этой позиции
            }
        }

        int help = array[i];            //ВСПОМИНАЙ! пузырьковая замена. мы меняем местами значения в переменных
        array[i] = array[minPosition];  // при помощи вспомогательной переменой help
        array[minPosition] = help;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

