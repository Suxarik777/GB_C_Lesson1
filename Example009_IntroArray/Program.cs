int MaxFunction(int arg1, int arg2, int arg3) //здесь мы задаём функцию 
{                               //принимаются данные в скобки в том же порядке как ниже в коде (a1,b1,c1)  
    int result = arg1;          //и им присваивается (arg1, int arg2, int arg3)  
    if (arg2 > result) result = arg2;    //(int - помни это просто тип данных (контейнер) целочисленный) 
    if (arg3 > result) result = arg3;    //просто его мы решили указать в функции
    return result;
}

// индексы       0   1   2   3   4   5   6  7    8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };



int result = MaxFunction(
    MaxFunction(array[0], array[1], array[2]),
    MaxFunction(array[3], array[4], array[5]),
    MaxFunction(array[6], array[7], array[8])
);
Console.WriteLine(result);






//int max = MaxFunction(          // можно записать одной строкой! int max = MaxFunction(MaxFunction(a1,b1,c1), MaxFunction(a2,b2,c2), MaxFunction(a3,b3,c3));
//    MaxFunction(a1, b1, c1),
//    MaxFunction(a2, b2, c2),
//    MaxFunction(a3, b3, c3)
//);


//int max1 = MaxFunction(a1,b1,c1); //MaxFunction(берёт сюда информацию из указанных в переменных a,b,c)
//int max2 = MaxFunction(a2,b2,c2);   //MaxFunction - это название, можно дать любое, например в лекции просто MAX
//int max3 = MaxFunction(a3,b3,c3);

//int max = MaxFunction(max1,max2,max3);