int MaxFunction(int arg1, int arg2, int arg3) //здесь мы задаём функцию 
{                               //принимаются данные в скобки в том же порядке как ниже в коде (a1,b1,c1)  
    int result = arg1;          //и им присваивается (arg1, int arg2, int arg3)  
    if(arg2 > result) result = arg2;    //(int - помни это просто тип данных (контейнер) целочисленный) 
    if(arg3 > result) result = arg3;    //просто его мы решили указать в функции
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

int max1 = MaxFunction(a1,b1,c1); //MaxFunction(берёт сюда информацию из указанных в переменных a,b,c)
int max2 = MaxFunction(a2,b2,c2);   //MaxFunction - это название, можно дать любое, например в лекции просто MAX
int max3 = MaxFunction(a3,b3,c3);

int max = MaxFunction(max1,max2,max3);



Console.WriteLine(max);