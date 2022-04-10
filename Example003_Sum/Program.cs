int numberA = new Random().Next(1,10); // 1 2 3 4 ... 9
Console.WriteLine(numberA + " + ");
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);



//Console.WriteLine(numberA + numberB); вариант номер 1, положить формулу прямо в команду вывода на экран

//int result = numberA + numberB;
//Console.WriteLine(result);        вар. 2 это делаем переменную результат и уже потом эту переменную выводим в сообщение